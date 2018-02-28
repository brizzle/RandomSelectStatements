using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogus;

namespace winRandomSelectStatements
{
    public class DataGenerator<TEntity> where TEntity : new()
    {
        public TEntity GetObject()
        {
            return new TEntity();
        }

        public string CreateViewCreation()
        {
            var item = GetObject();
            var viewCreateSql = new StringBuilder();

            viewCreateSql.AppendLine($"CREATE OR REPLACE FORCE VIEW {typeof(TEntity).Name} ( ");

            foreach (var propertyInfo in item.GetType().GetProperties())
            {
                viewCreateSql.AppendLine($@"     ""{propertyInfo.Name}"",");
            }
            viewCreateSql.Length -= 3;
            viewCreateSql.AppendLine(") AS ");
            return viewCreateSql.ToString();
        }
        public string CreateSelectLine()
        {

            var item = GetObject();

            var sql = new StringBuilder();
            sql.Append("Select ");



            foreach (var propertyInfo in item.GetType().GetProperties())
            {

                var typeCode = Type.GetTypeCode(propertyInfo.PropertyType);
                switch (typeCode)
                {
                    case TypeCode.DateTime:
                        var newDate = BuildDateTime(propertyInfo.Name);
                        //propertyInfo.SetValue(item, CreateRandomDate());
                        sql.Append($"to_Date('{newDate}', 'mm/dd/yyyy') as {propertyInfo.Name},");
                        break;
                    case TypeCode.String:
                        var newValue = BuildString(propertyInfo.Name);
                        //   propertyInfo.SetValue(item, CreateRandomAlphaNumeric(5));
                        sql.Append($"'{newValue}' as {propertyInfo.Name},");
                        break;
                    case TypeCode.Boolean:
                        var newBool = new Faker().Random.Bool();
                        sql.Append($"'{newBool}' as {propertyInfo.Name},");
                        break;
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                        sql.Append($"{BuildInt(propertyInfo.Name)} as {propertyInfo.Name},");
                        break;
                    case TypeCode.Decimal:
                        sql.Append($"{FakeData.RandomDecimal()} as {propertyInfo.Name},");
                        break;
                }


            }

            sql.Length -= 1;
            sql.Append(" from dual ");

            return sql.ToString();

        }


        public string BuildInt(string field)
        {
            if (field.ToLower().Contains("area_code"))
            {
                return FakeData.RandomRandomInt(100, 999).ToString();
            }
            if (field.ToLower().Contains("phone_number"))
            {
                return FakeData.RandomRandomInt(5551111, 5559999).ToString();
            }
            if (field.ToLower().Contains("ssn"))
            {
                return FakeData.RandomRandomInt(111223333, 888998899).ToString();
            }

            if (field.ToLower().Contains("rank"))
            {
                return "1";
            }

            if (field.ToLower().Contains("time_slot"))
            {
                return FakeData.RandomRandomInt(1, 12).ToString();
            }

            if (new List<string>
            {
                "session_start_time",
                "session_end_time",
                "session_time",
                "time_from",
                "time_to"
            }.Contains(field.ToLower()))
            {
                return (FakeData.RandomRandomInt(1, 12) * 100).ToString();
            }

            if (new List<string>
            {
                "title_code",
                "unit_id"
            }.Contains(field.ToLower()))
            {
                return (FakeData.RandomRandomInt(1, 5) * 100).ToString();
            }
            if (new List<string>
            {
                "session_month"
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomRandomInt(1, 12).ToString();
            }
            if (new List<string>
            {
                "pay_period_number",
                "PAY_PERIOD".ToLower()
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomRandomInt(1, 2).ToString();
            }


            if (field.ToLower().Contains("_year"))
            {
                return FakeData.RandomRandomInt(2019, 2019).ToString();
            }

            return FakeData.RandomRandomInt(1000, 5999).ToString();
        }

        private string BuildDateTime(string field)
        {
            if (field.ToLower().Contains("from_date"))
            {
                return DateTime.Now.ToString("MM/dd/yyyy");
            }

            if (field.ToLower().Contains("to_date"))
            {
                return DateTime.Now.AddDays(14).ToString("MM/dd/yyyy");
            }

            return FakeData.RandomDate().ToString("MM/dd/yyyy");
        }
        private string BuildString(string field)
        {

            if (new List<string>
            {
                "ASSIGNMENT_CODE".ToLower(),

            }.Contains(field.ToLower()))
            {
                return FakeData.RandomAssignment_Code();
            }
            if (new List<string>
            {
                "ASSIGNMENT".ToLower(),
                "ASSIGNMENT_CODE".ToLower(),
                "supervisor_code"

            }.Contains(field.ToLower()))
            {
                return FakeData.RandomAssignment_Code();
            }

            if (new List<string>
            {
                "CODE".ToLower(),
                "WIPP".ToLower(),
                "WIPP_TYPE".ToLower(),
                "CUSTODY_LEVEL".ToLower(),

            }.Contains(field.ToLower()))
            {
                return FakeData.RandomCode();
            }


            // people names
            if (new List<string>
            {
                "inmate_name",
                "VISITOR_NAME".ToLower(),
                "STAFF_NAME".ToLower(),
                "REPORTED_BY".ToLower(),
                "PLAN_MANAGER".ToLower(),
                "FACILITATOR_NAME".ToLower(),
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomName();
            }

            if (field.ToLower().Contains("SUPERVISOR".ToLower()) ||
                field.ToLower().Contains("shift_commander"))
            {
                return FakeData.RandomSupervior();
            }


            //location info
            if (field.ToLower().Contains("prison"))
            {
                return FakeData.RandomPrison();
            }
            if (field.ToLower().Contains("building_name") ||
                field.ToLower().Contains("HOUSING_UNIT".ToLower()) ||
                field.ToLower().Contains("location_desc") ||
                field.ToLower().Contains("LOCATION_CODE_DESC".ToLower()))
            {
                return FakeData.RandomBuilding();
            }
            if (field.ToLower().Contains("unit_name"))
            {
                return FakeData.RandomUnitName();
            }
            if (field.ToLower().Contains("bed"))
            {
                return FakeData.RandomBed();
            }
            if (field.ToLower().Contains("locator_code") ||
                field.ToLower().Contains("location_code") ||
                field.ToLower().Contains("shift_area") ||
                field.ToLower().Contains("shield_position"))
            {
                return FakeData.RandomBed();
            }



            // other items
            if (field.ToLower().Contains("gender"))
            {
                return FakeData.RandomGender(true);
            }
            if (field.ToLower().Contains("race") ||
                field.ToLower().Contains("ethnic"))
            {
                return FakeData.RandomRace();
            }
            if (field.ToLower().Contains("relationship"))
            {
                return FakeData.RandomRelationShip();
            }
            if (new List<string>
            {
                "minor_flag",
                "NEW_INFORMATION".ToLower(),
                "WARDEN_APPROVAL".ToLower(),
                "WARDEN_DENIAL".ToLower(),
                "NO_VISITS_INDICATOR".ToLower(),
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomYesNO(true);
            }


            if (new List<string>
                {
                    "VISITOR_STATUS".ToLower(),
                    "INMATE_STATUS".ToLower(),
                    "VISIT_TERMINATION_STATUS".ToLower()
                }.Contains(field.ToLower()))
            {
                return FakeData.RandomStatus();
            }


            if (new List<string>
            {
                "visitor_type",
                "program_type",
                "PROGRAM_CATEGORY".ToLower(),
                "PROGRAM_ASSIGNMENT".ToLower(),
                "DI83_PGM".ToLower(),
                "CAPACITY_GROUP".ToLower(),
                "IPP_TYPE".ToLower()
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomType();
            }

            if (new List<string>
            {
                "category",
                "category_code",
                "title_code",
                "title_description"
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomCategory();
            }


            if (new List<string>
            {
                "work_assignment"
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomWorkAssignment();
            }


            if (new List<string>
            {
                "PROGRAM_STATUS".ToLower(),
                "TYP".ToLower(),

            }.Contains(field.ToLower()))
            {
                return FakeData.RandomProgram_status();
            }

            if (new List<string>
            {
                "group_no",
                "group_id"
            }.Contains(field.ToLower()))
            {
                return FakeData.RandomGroup_Id();
            }


            return FakeData.RandomAlphaNumeric(5);

        }




    }
}