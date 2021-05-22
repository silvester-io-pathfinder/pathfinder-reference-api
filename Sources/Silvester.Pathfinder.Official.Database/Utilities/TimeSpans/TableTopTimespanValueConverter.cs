using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Silvester.Pathfinder.Official.Database.Utilities.TimeSpans.Enums;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Utilities.TimeSpans
{
    public class TableTopTimespanValueConverter : ValueConverter<TableTopTimeSpan, string>
    {
        public TableTopTimespanValueConverter()
            : base((ts) => Serialize(ts), (value) => Deserialize(value))
        {

        }

        private static string Serialize(TableTopTimeSpan timespan)
        {
            return timespan.ToString()!;
        }

        private static TableTopTimeSpan Deserialize(string value)
        {
            if (TimeSpan.TryParse(value, out TimeSpan timeSpan))
            {
                return new StaticTimeSpan { TimeSpan = timeSpan };
            }
            else
            {
                //e.g:
                //7 minutes
                //4d6 + 2d8 + 7 minutes
                string[] segments = value.Split(" + ");
                string[] segmentIncludingTimeUnit = segments.Last().Split(" ");
                segments[segments.Length - 1] = segmentIncludingTimeUnit[0];

                DiceTimeSpan diceTimeSpan = new DiceTimeSpan();
                diceTimeSpan.TimeUnit = Enum.Parse<TimeUnit>(segmentIncludingTimeUnit[1]);

                foreach (string segment in segments)
                {
                    if (segment.Contains("d"))
                    {
                        string[] components = segment.Split("d");
                        diceTimeSpan.DiceCollection.Dice.Add(new Dice
                        {
                            Die = Enum.Parse<Die>("d" + int.Parse(components[1])),
                            Amount = int.Parse(components[0])
                        });
                    }
                    else
                    {
                        diceTimeSpan.DiceCollection.Bonus += int.Parse(segment);
                    }
                }

                return diceTimeSpan;
            }
        }
    }
}
