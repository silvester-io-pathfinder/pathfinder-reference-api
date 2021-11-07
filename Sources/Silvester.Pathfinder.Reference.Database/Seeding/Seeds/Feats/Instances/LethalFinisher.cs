using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LethalFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("3c34f4fe-e819-409b-bcd9-269e6f75619c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lethal Finisher",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6cc8e51c-1dd3-4515-b729-a5bf98a93b05"), Type = TextBlockType.Text, Text = "You stab your foe in a vital organ, possibly killing them outright. Make a (action: Strike). On a success, you forego your precise strike damage from the finisher. Instead, your target takes additional precision damage based on a Fortitude save against your class DC. If your (action: Strike) was a critical hit, the target’s saving throw outcome is one degree worse." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("ec8666ea-9f3d-4f82-b5e0-f731d2da7fc8"), ClassFeatures.Swashbucklers.PreciseStrike.ID);
            builder.HaveSpecificLevel(Guid.Parse("89dfb125-882b-4ffd-8cb7-e442fbed8123"), Comparatos.GreaterThanOrEqualTo, level: 17);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("b009bf77-41eb-4cdf-a346-0e07741e2211"),
                CriticalSuccess = "You deal 6 precision damage.",
                Success = "You deal 6d6 precision damage.",
                Failure = "You deal 12d6 precision damage.",
                CriticalFailure = "You deal 18d6 precision damage.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5927466f-a91f-4c1e-8a7a-7e885cf08b9f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
