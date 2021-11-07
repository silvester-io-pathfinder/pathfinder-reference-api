using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GigatonStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("65695250-bf2a-4f3b-aae1-e28c1d529e2f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gigaton Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, this benefit applies on its (trait: unstable) (feat: Megaton Strikes | Megaton Strike).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8685eac9-6c2f-4a52-a8ff-3941769065c7"), Type = TextBlockType.Text, Text = "When you use a full-power (feat: Megaton Strike), you can knock your foe back. When you succeed at your (action: Strike) while using an (trait: unstable) (feat: Megaton Strike), your target must attempt a Fortitude save against your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9f35e6cb-cee3-490c-a5b8-793026606209"), Feats.Instances.MegatonStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("75f9a137-eb3b-4d67-b0e9-65f3587ad366"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is pushed back 5 feet.",
                Failure = "The creature is pushed back 10 feet.",
                CriticalFailure = "The creature is pushed back 20 feet.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e473940-d6cd-471f-80cc-71a736b84162"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
