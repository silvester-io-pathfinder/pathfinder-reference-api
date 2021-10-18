using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Entertainer : Template
    {
        public static readonly Guid ID = Guid.Parse("4f419ec1-4cbc-4694-9345-5f35a12abefa");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Entertainer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7cff8a90-fec7-4e1c-86a1-b74930d69089"), Type = TextBlockType.Text, Text = "Through an education in the arts or sheer dogged practice, you learned to entertain crowds. You might have been an actor, a dancer, a musician, a street magician, or any other sort of performer." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("03811ffd-e600-41d0-9412-9e94ed8f39af"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("1abe488a-a4aa-4e9c-bce0-66a1754f3f7b"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("cb3fa7bc-c6f8-4190-af48-f4d8d2519641"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("71ad6b02-3feb-4f19-b0d7-649840f57082")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("ac059e9b-4318-455b-845f-601380210538"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Performance.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("9d229ba0-4ab5-40fb-9cce-25322e23b0c0"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Theater.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("edce8041-4ac4-4ac7-8843-b4b510b7d402"),
                FeatId = Feats.General.FascinatingPerformanceFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f793dc51-938b-44fb-beda-bba00a6b77f2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
