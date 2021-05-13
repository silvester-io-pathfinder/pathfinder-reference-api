using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Tane : Template
    {
        public static readonly Guid ID = Guid.Parse("aa8893c0-9319-40f1-afdc-205258e811e3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Tane",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e8589f9-693e-4b0e-a8bb-7889dc9f748b"), Type = TextBlockType.Text, Text = "The Tane are powerful creatures created eons ago by the Eldest of the First World. All of the Tane treat whatever plane they happen to be on as their home plane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("617969c6-da40-413f-a9cc-896d88f571f6"),
                SourceId = Bestiary2.ID,
                Page = 310
            };
        }
    }
}
