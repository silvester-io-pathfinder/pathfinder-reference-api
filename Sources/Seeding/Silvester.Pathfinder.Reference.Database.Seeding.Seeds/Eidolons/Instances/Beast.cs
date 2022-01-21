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
        public static readonly Guid ID = Guid.Parse("73ea0dcf-6316-4626-aa36-6aa6238b595a");

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
            builder.GainSpecificSpellCasting(Guid.Parse("56dc2d04-9599-4bd7-884f-12714099d250"), MagicTraditions.Instances.Primal.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("9b7b27ad-5780-4893-8357-66b7ba08be21"),
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
                Id = Guid.Parse("2f7f6840-7e3a-4326-a51d-82fe4c3b3cd7"),
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
                Id = Guid.Parse("9836d783-dbe7-40f9-b846-9a912ac7b06a"),
                Name = "Beast's Charge",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b4c4b74d-5cfa-431f-b908-b6c4338b698f"), Type = TextBlockType.Text, Text = "Your eidolon can make a ferocious charge or pounce on foes, allowing it to quickly engage. It gains the Beast's Charge activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("aaf4d4bd-5b46-4aed-8676-281d6a4adba7"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("0c81e7be-fac1-4a11-92e7-ddf513263e0a"), Feats.Instances.BeastsCharge.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("5210f905-7bb2-439f-86df-253d0c27c9db"),
                Name = "Primal Roar",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("28672885-c871-4eb0-9ccb-cbe90a253c03"), Type = TextBlockType.Text, Text = "Your eidolon can bellow a terrifying roar, screech, croak, or other overpowering sound to frighten foes. It gains the Primal Roar activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("0cfe7253-029b-4c76-8d2c-0a090ab2538d"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("f7ae2356-6886-4760-a6be-c00dcf8b5a40"), Feats.Instances.PrimalRoar.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("788a0db9-8b11-41e1-8575-19cb179bd913"),
                Name = "Whirlwind Maul",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("532aa5c4-53e2-47b1-9802-7fa8af0b3e6d"), Type = TextBlockType.Text, Text = "Your eidolon thrashes violently, damaging many foes in its reach. It gains the Whirlwind Maul activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("b09b5065-3b13-47e7-b0e8-78a9e5338eb1"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("a6fc0354-d63d-493e-bf9e-5609b170246c"), Feats.Instances.WhirlwindMaul.ID);
                })
                .Build()
            };
        }

        protected override IEnumerable<EidolonHomePlane> GetHomePlanes()
        {
            yield return new EidolonHomePlane
            {
                Id = Guid.Parse("a16f02d3-6974-4053-8e8a-c842a95a8553"),
                PlaneId = Planes.Instances.MaterialPlane.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d74a015-b877-49b7-adec-875b37207fb6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 61
            };
        }
    }
}
