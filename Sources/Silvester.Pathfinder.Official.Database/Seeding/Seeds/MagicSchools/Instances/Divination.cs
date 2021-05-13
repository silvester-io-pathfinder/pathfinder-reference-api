using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.MagicSchools.Instances
{
    public class Divination : Template
    {
        public static readonly Guid ID = Guid.Parse("cbb0592d-be14-4588-a0af-1f16aad3a4a6");

        protected override MagicSchool GetMagicSchool()
        {
            return new MagicSchool
            {
                Id = ID,
                Name = "Divination",
                Abbreviation = "DIV",
                Description = "Divinations allow you to learn the secrets of the present, past, and future.They bestow good fortune, grant you the ability to perceive remote locations, and reveal secret knowledge. Divinations often have the detection trait if they find something, the prediction trait if they grant you insight about what might happen in the future, the revelation trait if they show things as they truly are, or the scrying trait if they let you perceive another location."
            };
        }
    }
}
