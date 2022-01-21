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
        public static readonly Guid ID = Guid.Parse("1d8d16e7-b616-4c60-af73-8c52071b303d");

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
            builder.GainSpecificSpellCasting(Guid.Parse("f8d40e9b-2227-4e3c-9a3d-256db6af0129"), MagicTraditions.Instances.Arcane.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("25191509-98ff-427c-b55f-a76ac75f98b2"),
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
                Id = Guid.Parse("846215b9-3cac-4bc6-9ed1-af8275e5289b"),
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
                Id = Guid.Parse("2954b188-e6d9-4565-93bd-12509684711b"),
                Name = "Breath Weapon",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("fe5047c1-9083-4336-b72c-d70dfeba5a74"), Type = TextBlockType.Text, Text = "Your eidolon has a powerful breath weapon, which they are able to use regularly to wreak havoc upon your foes. They gain the Breath Weapon activity. Choose a damage type from among acid, cold, electricity, fire, negative, piercing, or poison, and choose whether the area is a 60-foot line or a 30-foot cone. Unless you chose piercing damage, both Breath Weapon and your eidolon gain the trait matching the damage type."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("380d4d17-5541-4ad7-baa1-4e8658b23369"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("6806770a-1f65-4e7a-a601-ce165e78b999"),
                Name = "Draconic Frenzy",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("4b1d528f-6ce5-498b-929f-c635a3764042"), Type = TextBlockType.Text, Text = "Your eidolon can make a furious assault, potentially recovering the use of their Breath Weapon. They gain the Draconic Frenzy activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("3a9d8e8e-5695-4325-aa72-bd54ff2337d5"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("2001c841-29d6-4658-b674-ece0ebc0dc3a"), Feats.Instances.DraconicFrenzy.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("50f14f22-45c2-4a76-a058-842f5a4d1dce"),
                Name = "Wyrm's Breath",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("452f271f-612e-4232-a532-b33ce679d675"), Type = TextBlockType.Text, Text = "Your eidolon can draw upon the power of wyrms to enhance the eidolon's Breath Weapon. Your eidolon gains the Wyrm's Breath free action."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("16ccd44c-634a-4d7d-be88-77cd8e3b8596"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("31853a76-1318-46e1-969c-b356db8dee61"), Feats.Instances.WyrmsBreath.ID);
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse("890bcd7c-edee-4129-b832-a69c6c1cf956"),
                PlaneId = Planes.Instances.AstralPlane.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6163c33-c8b2-4193-aa87-43b91bd5f851"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 64
            };
        }
    }
}
