using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GigatonStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("d153408b-d0d2-4bc5-91b1-b9d88c76b796");

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
            yield return new TextBlock { Id = Guid.Parse("327b20f4-12a1-44c1-86fb-977747c0a1c7"), Type = TextBlockType.Text, Text = "When you use a full-power (feat: Megaton Strike), you can knock your foe back. When you succeed at your (action: Strike) while using an (trait: unstable) (feat: Megaton Strike), your target must attempt a Fortitude save against your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("47cc9157-2582-4a18-9201-bb9ee01f1c15"), Feats.Instances.MegatonStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6a6decc0-efcc-428b-adab-9691d4b31f47"),
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
                Id = Guid.Parse("4e2d6040-d615-44e8-a819-838a926ac152"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
