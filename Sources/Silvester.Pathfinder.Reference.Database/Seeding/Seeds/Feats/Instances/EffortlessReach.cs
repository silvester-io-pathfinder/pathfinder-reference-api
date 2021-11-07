using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EffortlessReach : Template
    {
        public static readonly Guid ID = Guid.Parse("c62092c1-29d8-4683-8383-37aa48f1c4e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Effortless Reach",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fbcb844d-0b72-44bb-a0ac-593ea76d22cb"), Type = TextBlockType.Text, Text = "Focusing the powers of your ki to augment your blows, you stretch and lengthen your body in ways that defy logic. Your unarmed attacks gain the (trait: reach) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f03e944-0d11-4be8-b350-c6bdb2bf9ab0"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
