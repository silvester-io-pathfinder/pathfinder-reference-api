using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MysticTutor : Template
    {
        public static readonly Guid ID = Guid.Parse("46cafcc7-8033-4c67-9e0e-00ab06b0ec88");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Mystic Tutor",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("db7efe9c-c5d9-491f-a0da-be8f18c7d17c"), Type = TextBlockType.Text, Text = "You spent years predicting, identifying, and harnessing the innate magical talents of those around you. A magic-rich world has taught you that you can never have too much training when everyone around you is capable of magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.PervasiveMagic.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("cc7d1c5c-6ad1-41c7-a41f-32b49b8a0884"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("c1705eb0-93de-4322-b9bb-ede421475bbf"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("16c84599-df4b-4a47-ae83-735183485c21"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("6bc24ccd-465d-41ed-8f4b-38de5836e2d4")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("2ce061c6-f236-425a-85af-593c17bd5ecb"),
                Choices = new Effect[]
                {
                    new CombinedEffect
                    {
                        Id = Guid.Parse("2d2ffbee-af33-476f-8a0a-7ca005aba3fc"),
                        Entries = new Effect []
                        {
                            new GainSpecificTraitEffect {Id = Guid.Parse("94cd12ac-678e-4f75-8f9e-b56d56266df1"), TraitId = Traits.Instances.Arcane.ID},
                            new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("5fe28b2f-a786-4c41-a747-4bcef2285fb1"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Arcana.ID }
                        }
                    },
                    new CombinedEffect
                    {
                        Id = Guid.Parse("38621feb-dd05-48ec-9454-17bad1d919a6"),
                        Entries = new Effect []
                        {
                            new GainSpecificTraitEffect {Id = Guid.Parse("81efac41-e6f8-4a6b-acf3-3fefc7b9c349"), TraitId = Traits.Instances.Occult.ID},
                            new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("72d2329a-6eb2-42b7-a873-064e75ad4d02"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID }
                        }
                    }
                }
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("d77c719e-6ce3-45e2-9bb1-1a90f42262ca"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Academia.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("10d46b12-fd2f-44ed-97cb-028522328459"),
                FeatId = Feats.General.RecognizeSpellFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14e8ccf1-6bc1-423a-b5db-7fb2b25653c4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 219
            };
        }
    }
}
