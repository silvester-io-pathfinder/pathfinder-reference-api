using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Modification : Template
    {
        public static readonly Guid ID = Guid.Parse("137abc6f-c17b-4b8f-ba86-e40d9754cbe7");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Modification",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4fc05394-79ba-4799-9f7f-8e9eea241e77"), Type = TextBlockType.Text, Text = "A feat with this trait alters the construction of your innovation. If you have the reconfigure class feature, you can retrain such a feat more easily" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("841d5677-fee3-4b86-9426-9bb2e399097e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 234
            };
        }
    }
}
