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
    public class CunningClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("ce337c97-0bcb-4d96-ad3e-9f5a205319ea");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cunning Climber",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("802ac689-1b9b-4bf8-ac82-8a2cc90a0c20"), Type = TextBlockType.Text, Text = $"Whether you are climbing a ship's rigging, a jungle tree, or a clock tower, you have an uncanny knack for finding footholds and handholds where larger creatures can't. You gain a climb Speed of 10 feet. You can take the Legendary Climber feat even if you don't have the {ToMarkdownLink<Models.Entities.Feat>("Quick Climb", Feats.Instances.QuickClimb.ID)} feat, provided you meet its other prerequisites." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6edd7355-20b5-44c5-93f9-c261393321c6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
