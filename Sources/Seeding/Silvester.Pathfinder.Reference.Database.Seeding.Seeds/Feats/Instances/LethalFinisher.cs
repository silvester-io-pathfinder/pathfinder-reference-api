using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LethalFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("3d1cc0a6-ff80-442f-a297-e10a9cc4063c");

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
            yield return new TextBlock { Id = Guid.Parse("07ae91b2-b63f-4866-bd6f-d0a6c37d50fb"), Type = TextBlockType.Text, Text = $"You stab your foe in a vital organ, possibly killing them outright. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. On a success, you forego your precise strike damage from the finisher. Instead, your target takes additional precision damage based on a Fortitude save against your class DC. If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} was a critical hit, the target's saving throw outcome is one degree worse." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("30fb7b2c-7c5e-42da-ac6d-20369424aae6"), ClassFeatures.Swashbucklers.PreciseStrike.ID);
            builder.HaveSpecificLevel(Guid.Parse("9d4a2025-498b-4d06-8855-df772aac033a"), Comparator.GreaterThanOrEqualTo, requiredLevel: 17);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("db07b302-4609-45fd-862e-5554eabcf97b"),
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
                Id = Guid.Parse("b252424c-388b-4819-878a-f4c63f2e832a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
