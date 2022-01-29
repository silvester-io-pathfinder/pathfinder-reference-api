using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Eidolons.Instances
{
    public class Angel : Template
    {
        public static readonly Guid ID = Guid.Parse("af90d1a1-9389-49ac-aa2d-0a85d359be2d");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Angel",
                Description = "Your eidolon is a celestial messenger, a member of the angelic host with a unique link to you, allowing them to carry a special message to the mortal world at your side. Most angel eidolons are roughly humanoid in form, with feathered wings, glowing eyes, halos, or similar angelic features. However, some take the form of smaller angelic servitors like the winged helmet cassisian angel instead. The two of you are destined for an important role in the plans of the celestial realms. Though a true angel, your angel eidolon's link to you as a mortal prevents them from casting the angelic messenger ritual, even if they somehow learn it.",
                SuggestedAttacks = "fist (bludgeoning), wing (bludgeoning), unarmed attacks shaped like a weapon",
                LanguageId = Languages.Instances.Celestial.ID,
                MagicTraditionId = MagicTraditions.Instances.Divine.ID,
            };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override IEnumerable<Guid> GetSenses()
        {
            yield return Senses.Instances.Darkvision.ID;
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
            yield return Skills.Instances.Religion.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Angel.ID;
            yield return Traits.Instances.Celestial.ID;
            yield return Traits.Instances.Eidolon.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("2b19e5fc-b7a0-454d-a58e-227dde936d7c"), MagicTraditions.Instances.Divine.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("97087222-50b2-4f03-b84e-bce0524e70ba"),
                Name = "Angelic Avenger",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 12,
                Charisma = 10,
                ArmorClass = 2,
                DexterityCap = 3
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse("5c59836e-fd3a-4265-91ee-7e2dd9cb5db8"),
                Name = "Angelic Emissary",
                Strength = 12,
                Dexterity = 18,
                Constitution = 12,
                Intelligence = 10,
                Wisdom = 12,
                Charisma = 14,
                ArmorClass = 1,
                DexterityCap = 4
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse("9be48a02-8ce6-4be6-a85d-a7a9b39db837"),
                Name = "Hallowed Strikes",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5f08a2f4-5dfe-4469-b866-1b8b5bb18cd1"), Type = TextBlockType.Text, Text = "Your eidolon's attacks are hallowed by the celestial realms. Your eidolon's unarmed Strikes deal an extra 1 good damage; as usual, this extra damage harms only evil creatures or those with a weakness to good damage. Additionally, your eidolon can make nonlethal attacks with its unarmed attacks without taking the usual -2 circumstance penalty."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("66408d97-89e2-4280-b68b-df4f2722f918"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("f8d05b0a-fbad-473d-a39f-657b5c67f594"),
                Name = "Traveler's Aura",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("45a80d53-99b7-4d42-a07e-44aecadbcf73"), Type = TextBlockType.Text, Text = "Your eidolon emanates a powerful aura - resembling that of an astral deva - that protects creatures as they travel. The aura has the abjuration, aura, and divine traits. Your eidolon and its allies within a 20-foot emanation are protected from severe heat and cold, and your eidolon is never flat-footed to creatures inside the aura that are of a lower level than the eidolon."},
                    new TextBlock {Id = Guid.Parse("f5a84292-c095-46d4-85a0-f0a8b97fa6ea"), Type = TextBlockType.Text, Text = "When you gain the transcendence class feature, this evolves to the full benefits of an astral deva; your eidolon and allies in the aura are protected from environmental damage from any plane, including severe and extreme heat and cold as well as more unusual dangers."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("a44b43fc-6757-4b31-9def-0c801432eaf3"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("39620e70-6559-4583-8c5e-9f5c1d88f92b"),
                Name = "Angelic Mercy",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("69d0a972-7b5c-4256-8500-dbf5614e246d"), Type = TextBlockType.Text, Text = "Your eidolon's angelic power allows them to assuage a variety of ailments, just like most other powerful angels. Your eidolon can cast remove curse, remove disease, remove fear, and remove paralysis once per day each as 9th-level divine innate spells."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("f1464bad-750a-442f-8f99-17beaafe85c9"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse("6ddbbbea-51e8-4198-9d34-c6a70cfeb41d"),
                PlaneId = Planes.Instances.Nirvana.ID,
                Prerequisite = BooleanPrerequisiteBuilder.CreateAnd(Guid.Parse("6a323cce-73d5-47f3-a366-b687f408783d"), and =>
                {
                    and.HaveSpecificAlignment(Guid.Parse("00fa6adc-d01e-45f0-bac0-324e55cf1daa"), Alignments.Instances.NeutralGood.ID);
                })
                .Build()
            };

            yield return new EidolonHomePlane
            {
                Id = Guid.Parse("0da99b31-6336-4c29-8efc-08e0dd7450a1"),
                PlaneId = Planes.Instances.Elysium.ID,
                Prerequisite = BooleanPrerequisiteBuilder.CreateAnd(Guid.Parse("d9c86813-f39d-46a2-b966-ac9fa259dd56"), and =>
                {
                    and.HaveSpecificAlignment(Guid.Parse("fd5cef17-a107-46d0-a63b-3581e3678266"), Alignments.Instances.ChaoticGood.ID);
                })
                .Build()
            };

            yield return new EidolonHomePlane
            {
                Id = Guid.Parse("3bb8b5de-86c0-4044-9be5-183ed9834ef9"),
                PlaneId = Planes.Instances.Heaven.ID,
                Prerequisite = BooleanPrerequisiteBuilder.CreateAnd(Guid.Parse("dd7a487f-2c2f-41b7-9a71-16965581f7fa"), and =>
                {
                    and.HaveSpecificAlignment(Guid.Parse("ad78d204-f644-41c3-806c-abe3beae9dc9"), Alignments.Instances.LawfulGood.ID);
                })
                .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4e6d535-e82a-4b47-ac0b-c5689abd9876"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 59
            };
        }
    }
}
