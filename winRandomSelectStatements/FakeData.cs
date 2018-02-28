using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bogus;

namespace winRandomSelectStatements
{
    public static class FakeData
    {
        public static int RandomRandomInt(int start, int stop)
        {
            return new Faker().Random.Int(start, stop);
        }

        public static decimal RandomDecimal()
        {
            return Decimal.Round(new Faker().Random.Decimal(1, 10),2);
        }

        public static DateTime RandomDate()
        {
            

            return new Faker().Date.Between(DateTime.Now.AddMonths(-5), DateTime.Now.AddMonths(5));

        }

        public static string RandomAssignment_Code()
        {
            var names = new List<string>
            {
                "AC1",
                "AC2",
                "AC3",
                "AC4",
            };
            return new Faker().PickRandom(names);
        }
        public static int RandomAssignment_CodeInt()
        {
            var names = new List<int>
            {
                11,
                22,
                33,
            };
            return new Faker().PickRandom(names);
        }

        public static string RandomAssignment()
        {
            var names = new List<string>
            {
                "Assign1",
                "Assign2",
                "Assign3",
                "Assign4",
            };
            return new Faker().PickRandom(names);
        }

        public static string RandomAlphaNumeric(int length)
        {
            return new Faker().Random.AlphaNumeric(length);
        }

        public static string RandomName()
        {
            var result = new Faker().Name.FullName().Replace("'", string.Empty);
            return result;
        }

        public static string RandomSupervior()
        {
            var names = new List<string>
            {
                "Natasha Dibbert",
                "Renee Volkman",
                //"Lawrence Schaden",
                //"Jordan Lebsack",
                //"Janiya Herzog",
                //"Augustine Parker",
                //"Cleta Jacobs",
                //"Camron Walsh",
                //"Makenna Parisian",
                //"Scotty Hoeger",
                //"Mariane Toy",
            };
            return new Faker().PickRandom(names);
        }
        public static string RandomPrison()
        {

            var prisons = new List<string>
            {
                "Douglas", "Eyman", "Lewis", "Perryville"
            };

            return new Faker().PickRandom(prisons);
        }

        public static string RandomBuilding()
        {
            var buildings = new List<string>
            {
                "Building1", "Building2", "Building3", "Building4", "Building5"
            };
            return new Faker().PickRandom(buildings);
        }

        public static string RandomUnitName()
        {
            var units = new List<string>
            {
                "Eggers",
                "Browning",
                "Bachman",
                "Complex",
                "Tunisia Unit",
                "Cerbat",
                "Screening"
            };
            return new Faker().PickRandom(units);
        }
        public static string RandomBed()
        {
            var alpha = new List<string>
            {
                "A", "B", "C", "D"
            };
            var f = new Faker();
            return $"{f.Random.Int(1, 10)}{f.PickRandom(alpha)}";
        }

        public static string RandomYesNO(bool isLong)
        {
            if (isLong)
            {
                return new Faker().PickRandom(new List<string>
                {
                    "Yes",
                    "No",
                });
            }
            return new Faker().PickRandom(new List<string>
            {
                "Y",
                "N",
            });
        }

        public static string RandomStatus()
        {
            return new Faker().PickRandom(new List<string>
            {
                "Regular",
                "Approved",
            });
        }

        public static string RandomGender(bool isLong)
        {
            if (isLong)
            {
                return new Faker().PickRandom(new List<string>
                {
                    "Male",
                    "Female"
                });
            }
            return new Faker().PickRandom(new List<string>
            {
                "M",
                "F"
            });
        }

        public static string RandomRace()
        {
            return new Faker().PickRandom(new List<string>
            {
                "Caucasion",
                "Afrian-American",
                "Native American",
                "Hispanic"
            });
        }

        public static string RandomRelationShip()
        {
            return new Faker().PickRandom(new List<string>
            {
                "Mother",
                "Father",
                "Sibling",
                "Other"
            });
        }

        public static string RandomGroup_Id()
        {
            return new Faker().PickRandom(
                new List<string>
                {
                    "GRP1",
                    "GRP2",
                    "GRP3"
                });
        }

        public static string RandomCustodyLevel()
        {
            return new Faker().PickRandom(new List<string>
            {
                "Minimum",
                "Medium",
                "Close",
                "Maximun"
            });
        }

        public static string RandomType()
        {
            return new Faker().PickRandom(new List<string>
            {
                "Type1",
                "Type2",
            });
        }

        public static string RandomCategory()
        {
            var units = new List<string>
            {
                "Cat1",
                "Cat2",
                "Cat3",
            };
            return new Faker().PickRandom(units);
        }

        public static string RandomCode()
        {
            var units = new List<string>
            {
                "Code1",
                "Code2",
            };
            return new Faker().PickRandom(units);
        }

        public static string RandomWorkAssignment()
        {
            var units = new List<string>
            {
                "Assignment1",
                "Assignment2",
                "Assignment3",
            };
            return new Faker().PickRandom(units);
        }

        public static string RandomProgram_status()
        {
            var items = new List<string>
            {
                "EN",
                "AF",
                "RF",
                "AD",
                "CM",
                "RL",
            };
            return new Faker().PickRandom(items);
        }

        public static string RandomRegion()
        {
            var regs = new List<string>
            {
                "Reg1",
                "Reg2",
                "Reg3"
            };
            return new Faker().PickRandom(regs);
        }
    }
}