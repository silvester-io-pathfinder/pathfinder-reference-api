using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CriticalDebilitation : Template
    {
        public static readonly Guid ID = Guid.Parse("988d41f4-d90a-43a2-9674-46a1eaed276f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Critical Debilitation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c9a5cc2-cf00-4b82-8bc1-9d6b599bfebf"), Type = TextBlockType.Text, Text = "Your debilitations are especially effective on your most powerful attacks. Whenever you critically succeed at an attack roll against an enemy and use (feat: Debilitating Strike), add the following debilitation to the list you can choose from." };
            yield return new TextBlock { Id = Guid.Parse("729c1c38-a82f-445a-8a08-f134d941e665"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target attempts a Fortitude save against your class DC with the following effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("65424c40-e74f-449a-91b1-30d5f3acb946"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("1ea4de45-1e45-40fe-bc2f-0bc9d8b52758"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is slowed 1 until the end of your next turn.",
                Failure = "The target is slowed 2 until the end of your next turn.",
                CriticalFailure = "The target is paralyzed until the end of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36a97020-bf85-47b5-9a6f-2ad3da96bc86"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
