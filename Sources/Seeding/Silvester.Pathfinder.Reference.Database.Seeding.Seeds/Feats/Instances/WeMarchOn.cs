using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeMarchOn : Template
    {
        public static readonly Guid ID = Guid.Parse("f5c8473d-b9ce-4eb9-b3fc-6615709d4b4e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "We March On",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4d288dc-e84d-4708-8506-94f2ed7989db"), Type = TextBlockType.Text, Text = $"You make sure that your allies push themselves while traveling. You gain the {ToMarkdownLink<Models.Entities.Feat>("Caravan Leader", Feats.Instances.CaravanLeader.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Pick Up the Pace", Feats.Instances.PickUpThePace.ID)} general feats, even if you don't meet the prerequisites." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b305525a-6465-416c-b8c1-d340d7623d85"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
