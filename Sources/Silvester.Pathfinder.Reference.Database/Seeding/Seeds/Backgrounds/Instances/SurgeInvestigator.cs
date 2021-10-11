using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SurgeInvestigator : Template
    {
        public static readonly Guid ID = Guid.Parse("d378e1d8-c28e-4787-8684-29eb6be6fd66");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Surge Investigator",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("87742e15-5ed5-40b6-a242-d58631070dea"), Type = TextBlockType.Text, Text = "From rivers that charm all who come near to forests that speak through dream messages, you have seen and studied many kinds of magical terrain. The world is so rich in magic that it can affect the land itself, and you have traveled extensively to learn the ways of identifying the oddities of magical terrain wherever it arises." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.PervasiveMagic.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("5ccdc242-46a7-4741-8f16-0fe3f8616fda"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("22f7be62-b00f-4428-a598-40de6786aaf2"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("4cc8ffe1-81a0-4e4b-835d-7ec58ccec1af"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("4705a846-fabe-410a-9926-a65494b369ad")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("61ad22f1-fce7-4c57-8750-a5fb2fa0f06a"),
                Choices = new Effect[]
                {
                    new RestrictedSkillEffect { Id = Guid.Parse("d5cee513-10ac-47c7-ad3b-c94d85089965"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Nature.ID },
                    new RestrictedSkillEffect { Id = Guid.Parse("f047f221-3e07-4924-9636-c6f4ec14f789"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID },
                }
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("86389928-dfd2-4d2c-b61a-0bd96b787954"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.MagicalTerrain.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("d68c8b06-8df9-4bc0-a40f-11e07b5b4fd6"),
                FeatId = Feats.General.TerrainExpertiseFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d6905b1-99e0-46fd-ae18-f8dc237d4455"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 219
            };
        }
    }
}
