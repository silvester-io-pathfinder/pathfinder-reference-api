using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class DoubleBarrel : Template
    {
        public static readonly Guid ID = Guid.Parse("7a4c85d7-5160-40b7-bcf1-a034665dfa2b");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Double Barrel",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cba7b60e-66ae-4099-9574-8586430c943f"), Type = TextBlockType.Text, Text = "This weapon has two barrels that are each loaded separately. You can fire both barrels of a double barrel weapon in a single Strike to increase the size of the weapon damage die by one step. If the weapon has the fatal trait, this increases the size of the fatal die by one step as well." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("990fc5e6-7355-478e-8b3e-17085e8038be"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
