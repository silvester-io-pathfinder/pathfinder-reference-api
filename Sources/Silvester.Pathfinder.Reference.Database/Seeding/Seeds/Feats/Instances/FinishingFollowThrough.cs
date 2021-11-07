using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinishingFollowThrough : Template
    {
        public static readonly Guid ID = Guid.Parse("d435d5c8-4955-412e-b67d-153429c45e87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finishing Follow-Through",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30b0d477-f83b-4f61-855c-030733a9d9d4"), Type = TextBlockType.Text, Text = "Finishing a foe maintains your swagger. You gain panache if your (trait: finisher) brings the target to 0 HP (or brings the highest-level target to 0 HP, if your (trait: finisher) attacks multiple targets)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("629d1bf4-bd40-41a5-b655-165f044de54d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
