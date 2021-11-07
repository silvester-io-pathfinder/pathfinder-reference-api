using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrcWarmaskTheLand : Template
    {
        public static readonly Guid ID = Guid.Parse("6b08cdb4-5423-4e2a-a1d1-b955f4aeb601");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orc Warmask - The Land",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ba9a672-f145-4e45-810b-c762ea5f3146"), Type = TextBlockType.Text, Text = "The source of your (item: warmask | warmask the land)’s power is from the land. You become trained in Nature and your mask&#39;s magical tradition is (trait: primal)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6927fad6-018c-45ef-a6cf-7b55faa8fbb0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
