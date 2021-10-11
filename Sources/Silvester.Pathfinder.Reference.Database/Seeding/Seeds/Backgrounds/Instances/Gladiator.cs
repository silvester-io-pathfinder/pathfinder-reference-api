using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Gladiator : Template
    {
        public static readonly Guid ID = Guid.Parse("9210f894-a46d-47df-a118-e0d2eb2fb030");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Gladiator",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("521dd03c-9677-4876-ba0c-f1d2c288012f"), Type = TextBlockType.Text, Text = "The bloody games of the arena taught you the art of combat. Before you attained true fame, you departed'or escaped'the arena to explore the world. Your skill at drawing both blood and a crowd's attention pay off in a new adventuring life." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("456f882d-f29d-4a7d-946c-9300ef81cf7d"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("11a5d706-ef75-4965-b0ac-2038ff4d0614"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("322bc6fd-c673-4aa4-a889-83bb702b120b"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("410905ea-5cf6-493e-952e-23c4e977cb2b")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("7c867d7d-656f-4cc1-801a-507530d7806b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Performance.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("a4be0c84-b39e-4292-8c7f-9339dbb2851b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Gladiatorial.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("a61ccfbb-e200-40b4-b7b1-72361e8f2734"),
                FeatId = Feats.General.ImpressivePerformanceFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6fef9205-aa5f-4241-9c74-6f018825fc25"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
