using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class LostOmensCharacterGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("6c9b166a-9ba0-46ef-8089-2a9bf07f1422");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Lost Omens - Character Guide"
            };
        }
    }
}
