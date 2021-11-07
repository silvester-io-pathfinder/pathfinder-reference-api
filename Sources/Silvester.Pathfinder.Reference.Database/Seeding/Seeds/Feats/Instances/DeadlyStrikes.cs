using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlyStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("b2c7253f-e548-4514-bfa1-20db6643f181");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Strikes",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb2e9bb0-cb71-4649-838d-3ee2ed6dd6a8"), Type = TextBlockType.Text, Text = "You have honed your body to attack with lethal focus. Your unarmed attacks gain the (trait: deadly d10) trait, or you increase their (trait: deadly) trait to d10 if the unarmed attack is already deadly with a smaller die size." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e0b545a-f5bb-439a-96ed-a052d2c48ba0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
