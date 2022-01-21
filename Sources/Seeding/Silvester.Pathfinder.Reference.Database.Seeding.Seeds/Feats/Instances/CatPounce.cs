using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatPounce : Template
    {
        public static readonly Guid ID = Guid.Parse("e9190629-362e-4f83-8ec6-a80742065fc3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cat Pounce",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75d6d588-63d9-438e-b720-29b5d2a25d91"), Type = TextBlockType.Text, Text = $"The cat {ToMarkdownLink<Models.Entities.Action>("Strides", Actions.Instances.Stride.ID)} and then {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}. If it was undetected at the start of its Cat Pounce, it remains undetected until after the attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("915b4606-bc63-44b8-85f2-f89a4444806e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
