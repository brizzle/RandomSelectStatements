using System;
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
                        var newDate = FakeData.RandomDate().ToString("MM/dd/yyyy");
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
            return FakeData.RandomRandomInt(1000, 5999).ToString();
        }

        private string BuildString(string field)
        {

            // people names
            if (field.ToLower().Contains("inmate_name") ||
                field.ToLower().Contains("VISITOR_NAME".ToLower()) ||
                field.ToLower().Contains("STAFF_NAME".ToLower()))
            {
                return FakeData.RandomName();
            }
            if (field.ToLower().Contains("SUPERVISOR".ToLower()))
            {
                return FakeData.RandomSupervior();
            }


            //location info
            if (field.ToLower().Contains("prison"))
            {
                return FakeData.RandomPrison();
            }
            if (field.ToLower().Contains("building_name") ||
                field.ToLower().Contains("HOUSING_UNIT".ToLower()))
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
            if (field.ToLower().Contains("locator_code"))
            {
                return FakeData.RandomBed();
            }



            // other items
            if (field.ToLower().Contains("gender"))
            {
                return FakeData.RandomGender(true);
            }
            if (field.ToLower().Contains("race"))
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


            return FakeData.RandomAlphaNumeric(5);

        }




    }
}