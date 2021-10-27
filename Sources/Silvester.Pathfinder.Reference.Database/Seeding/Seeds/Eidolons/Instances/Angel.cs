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
        public static readonly Guid ID = Guid.Parse("");

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
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Divine.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
                Name = "Hallowed Strikes",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon's attacks are hallowed by the celestial realms. Your eidolon's unarmed Strikes deal an extra 1 good damage; as usual, this extra damage harms only evil creatures or those with a weakness to good damage. Additionally, your eidolon can make nonlethal attacks with its unarmed attacks without taking the usual –2 circumstance penalty."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Traveler's Aura",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon emanates a powerful aura—resembling that of an astral deva—that protects creatures as they travel. The aura has the abjuration, aura, and divine traits. Your eidolon and its allies within a 20-foot emanation are protected from severe heat and cold, and your eidolon is never flat-footed to creatures inside the aura that are of a lower level than the eidolon."},
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you gain the transcendence class feature, this evolves to the full benefits of an astral deva; your eidolon and allies in the aura are protected from environmental damage from any plane, including severe and extreme heat and cold as well as more unusual dangers."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Angelic Mercy",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon's angelic power allows them to assuage a variety of ailments, just like most other powerful angels. Your eidolon can cast remove curse, remove disease, remove fear, and remove paralysis once per day each as 9th-level divine innate spells."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
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
                Id = Guid.Parse(""),
                PlaneId = Planes.Instances.Nirvana.ID,
                Prerequisite = BooleanPrerequisiteBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.HaveSpecificAlignment(Guid.Parse(""), Alignments.Instances.NeutralGood.ID);
                })
                .Build()
            };

            yield return new EidolonHomePlane
            {
                Id = Guid.Parse(""),
                PlaneId = Planes.Instances.Elysium.ID,
                Prerequisite = BooleanPrerequisiteBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.HaveSpecificAlignment(Guid.Parse(""), Alignments.Instances.ChaoticGood.ID);
                })
                .Build()
            };

            yield return new EidolonHomePlane
            {
                Id = Guid.Parse(""),
                PlaneId = Planes.Instances.Heaven.ID,
                Prerequisite = BooleanPrerequisiteBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.HaveSpecificAlignment(Guid.Parse(""), Alignments.Instances.LawfulGood.ID);
                })
                .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 59
            };
        }
    }
}
