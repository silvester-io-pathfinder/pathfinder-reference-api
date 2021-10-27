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
    public class Beast : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Beast",
                Description = "Your eidolon is a manifestation of the life force of nature in the form of a powerful magical beast that often has animal features, possibly even several from different species. You might have learned the way to connect with the world's life force via a specific philosophy or practice, such as the beliefs of the god callers of Sarkoris, or formed a bond on your own. Regardless, your link to your eidolon allows you both to grow in power and influence to keep your home safe from those who would despoil it.",
                SuggestedAttacks = "claw (slashing), jaws (piercing), fangs (piercing), hoof (bludgeoning), horn (piercing)",
                LanguageId = Languages.Instances.Sylvan.ID,
                MagicTraditionId = MagicTraditions.Instances.Primal.ID,
            };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetSenses()
        {
            yield return Senses.Instances.LowLightVision.ID;
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Beast.ID;
            yield return Traits.Instances.Eidolon.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Primal.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
                Name = "Brutal Beast",
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
                Name = "Fleet Beast",
                Strength = 14,
                Dexterity = 18,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 12,
                Charisma = 10,
                ArmorClass = 1,
                DexterityCap = 4
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Beast's Charge",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can make a ferocious charge or pounce on foes, allowing it to quickly engage. It gains the Beast's Charge activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.BeastsCharge.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Primal Roar",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can bellow a terrifying roar, screech, croak, or other overpowering sound to frighten foes. It gains the Primal Roar activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.PrimalRoar.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Whirlwind Maul",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon thrashes violently, damaging many foes in its reach. It gains the Whirlwind Maul activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.WhirlwindMaul.ID);
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse(""),
                PlaneId = Planes.Instances.MaterialPlane.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 61
            };
        }
    }
}
