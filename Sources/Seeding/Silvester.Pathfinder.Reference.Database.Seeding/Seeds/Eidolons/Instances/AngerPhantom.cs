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
    public class AngerPhantom : Template
    {
        public static readonly Guid ID = Guid.Parse("88855958-a51c-465e-9a18-958fe99a9bb5");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Anger Phantom",
                Description = "Your eidolon is a lost soul, bound to the mortal world by undying anger or a bitter grudge. Most phantom eidolons are humanoids with a spectral or ectoplasmic appearance, though some take far stranger forms. Your link with your eidolon prevents it from succumbing to corruption and undeath. Together, you will need to decide whether to work with your eidolon to control its anger, or channel its wrath into power.",
                SuggestedAttacks = "fist (bludgeoning), tendril (bludgeoning), unarmed attacks shaped like a weapon",
                LanguageId = Languages.Instances.Common.ID,
                MagicTraditionId = MagicTraditions.Instances.Occult.ID,
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
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Eidolon.ID;
            yield return Traits.Instances.Ethereal.ID;
            yield return Traits.Instances.Phantom.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("3d1617a0-9e76-4fcf-9209-590b8897462d"), MagicTraditions.Instances.Occult.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("ec5981e3-e937-4fac-bccc-9daaea93b0e0"),
                Name = "Enraged Assassin",
                Strength = 14,
                Dexterity = 18,
                Constitution = 16,
                Intelligence = 10,
                Wisdom = 8,
                Charisma = 12,
                ArmorClass = 1,
                DexterityCap = 4
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse("bc467ec4-b99e-43d3-bb09-db3c17a2fcde"),
                Name = "Wrathful Berserker",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 8,
                Wisdom = 10,
                Charisma = 12,
                ArmorClass = 2,
                DexterityCap = 3
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse("7085ccff-683d-4822-b88e-e19aea07c15e"),
                Name = "Furious Strike",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("f8671da9-ac62-4ebe-9157-18e10189db4d"), Type = TextBlockType.Text, Text = "Your eidolon can infuse an attack with unmitigated rage. It gains the Furious Strike activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("721ad08a-d855-4471-a89a-2009f516c063"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("ee2f99b0-1cac-4733-96d8-4a90d122e369"), Feats.Instances.FuriousStrike.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("a4260f53-9d33-4e38-8d2d-e7cf996e2587"),
                Name = "Seething Frenzy",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("38e3e928-2460-41e1-9a7d-8c768b0de8d4"), Type = TextBlockType.Text, Text = "Your eidolon can stoke itself into a frenzy. It gains the Seething Frenzy action."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("0919a2de-e9d0-464f-8335-0c1cdd59f8fe"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("33dbbfbb-8cfb-4d81-ad0f-aca92f28a599"), Feats.Instances.SeethingFrenzy.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("c12c5d41-fd2d-4e1f-8ac3-209de3e7bcc8"),
                Name = "Anger Aura",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("dd2c6bd0-0472-4958-addd-8785a10455c2"), Type = TextBlockType.Text, Text = "Your eidolon exudes wrath in an aura around it, rousing the ire of nearby creatures and causing their defenses to crack as they seethe with rage. Your eidolon gains a 20-foot anger aura, which has the aura, emotion, enchantment, mental, and occult traits. The resistances of any creature in the aura, including you, your allies, your enemies, and your eidolon, are reduced by an amount equal to 3 + your eidolon's Constitution modifier. Your eidolon can hold in its rage by spending a single action, which has the concentrate trait. This reduces the aura's effect to affect only your eidolon. It can take this action again to reinstate the full effect of its aura. Creatures in a barbarian Rage, Seething Frenzy, or similar ability that allows them to channel their anger aren't affected by the anger aura."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("834c3b9b-5fe8-4fd2-8cad-0a143f2cf971"), and =>
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
                Id = Guid.Parse("f6a1d4b6-57ed-4678-bc1c-f2aeceb69c5d"),
                PlaneId = Planes.Instances.EtherealPlane.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eddb7973-cde2-47c7-8601-eb09c77aaed7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 59
            };
        }
    }
}
