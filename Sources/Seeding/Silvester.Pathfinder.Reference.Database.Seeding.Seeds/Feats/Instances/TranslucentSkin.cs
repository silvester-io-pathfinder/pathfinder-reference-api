using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TranslucentSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("e50c487a-40f8-47ca-a1cf-27a612ab531c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Translucent Skin",
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
            yield return new TextBlock { Id = Guid.Parse("00d7d80f-ebe7-44db-8922-539c4f7e44aa"), Type = TextBlockType.Text, Text = $"Your body is translucent while underwater. Whenever you are fully submerged in water, you can {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} from other creatures even if you don't have cover against them and aren't concealed from them." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fa929c9-7579-4a2f-8d2d-9b5e01ba6cd1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
