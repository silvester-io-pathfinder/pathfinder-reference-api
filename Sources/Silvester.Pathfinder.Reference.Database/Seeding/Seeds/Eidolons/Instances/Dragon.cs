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
    public class Dragon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Dragon",
                Description = "Because dragons have a strong connection to magic, their minds can often leave an echo floating in the Astral Plane. Such an entity is extremely powerful but unable to interact with the outside world on its own. Dragon eidolons manifest in the powerful, scaled forms they had in life; most take the form of true dragons (albeit smaller), but some manifest as drakes or other draconic beings. You have forged a connection with such a dragon eidolon and together, you seek to grow as powerful as an ancient wyrm.",
                SuggestedAttacks = "claw (slashing), jaws (piercing), horn (piercing), tail (bludgeoning), wing (bludgeoning)",
                LanguageId = Languages.Instances.Draconic.ID,
                MagicTraditionId = MagicTraditions.Instances.Arcane.ID,
            };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetSenses()
        {
            yield return Senses.Instances.Darkvision.ID;
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Astral.ID;
            yield return Traits.Instances.Dragon.ID;
            yield return Traits.Instances.Eidolon.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
                Name = "Cunning Dragon",
                Strength = 12,
                Dexterity = 18,
                Constitution = 12,
                Intelligence = 14,
                Wisdom = 10,
                Charisma = 12,
                ArmorClass = 1,
                DexterityCap = 4
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
                Name = "Marauding Dragon",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 10,
                Wisdom = 10,
                Charisma = 10,
                ArmorClass = 2,
                DexterityCap = 3
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Breath Weapon",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon has a powerful breath weapon, which they are able to use regularly to wreak havoc upon your foes. They gain the Breath Weapon activity. Choose a damage type from among acid, cold, electricity, fire, negative, piercing, or poison, and choose whether the area is a 60-foot line or a 30-foot cone. Unless you chose piercing damage, both Breath Weapon and your eidolon gain the trait matching the damage type."},
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
                Name = "Draconic Frenzy",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can make a furious assault, potentially recovering the use of their Breath Weapon. They gain the Draconic Frenzy activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DraconicFrenzy.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Wyrm's Breath",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can draw upon the power of wyrms to enhance the eidolon's Breath Weapon. Your eidolon gains the Wyrm's Breath free action."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.WyrmsBreath.ID);
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse(""),
                PlaneId = Planes.Instances.AstralPlane.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 64
            };
        }
    }
}
