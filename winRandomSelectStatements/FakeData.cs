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
                "Lawrence Schaden",
                "Jordan Lebsack",
                "Janiya Herzog",
                "Augustine Parker",
                "Cleta Jacobs",
                "Camron Walsh",
                "Makenna Parisian",
                "Scotty Hoeger",
                "Mariane Toy",
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
    }
}