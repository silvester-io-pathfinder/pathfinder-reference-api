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
    public class DevotionPhantom : Template
    {
        public static readonly Guid ID = Guid.Parse("829544ec-a0f3-4c3c-9564-1a3527823d56");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Devotion Phantom",
                Description = "Your eidolon is a lost soul, unable to escape the mortal world due to a strong sense of duty, an undying devotion, or a need to complete an important task. Most phantom eidolons are humanoid with a spectral or ectoplasmic appearance, though some take far stranger forms. Your link with your eidolon prevents them from succumbing to corruption and undeath, and together, you will grow in strength and fulfill your phantom's devotion.",
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
            yield return Skills.Instances.Medicine.ID;
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
            builder.GainSpecificSpellCasting(Guid.Parse("d7ae9ee4-de34-4553-9c3d-70e15623a448"), MagicTraditions.Instances.Occult.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("8febba36-98f7-43c3-947b-f3e4e11a0ab5"),
                Name = "Stalwart Guardian",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 10,
                Wisdom = 10,
                Charisma = 10,
                ArmorClass = 2,
                DexterityCap = 3
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse("fa3c31ae-70cd-447f-8a1f-fe50baa908b9"),
                Name = "Swift Protector",
                Strength = 14,
                Dexterity = 18,
                Constitution = 16,
                Intelligence = 10,
                Wisdom = 10,
                Charisma = 10,
                ArmorClass = 1,
                DexterityCap = 4
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse("8cb401ae-c085-4df7-9412-3d5097db12f1"),
                Name = "Dutiful Retaliation",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("853d2095-99b2-4e8f-b911-8fd29fcf7ae5"), Type = TextBlockType.Text, Text = "Your eidolon deeply respects your assistance, and it extends its loyalty to you, attacking those who dare harm you. It gains the Dutiful Retaliation reaction."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("dd64ffeb-10e3-44b9-8f01-535528e21860"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("69a64137-225e-479c-bb26-ab091b64bcc6"), Feats.Instances.DutifulRetaliation.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("b9204fbb-7cbc-4c6b-8a9a-86fbf1cfa1de"),
                Name = "Steadfast Devotion",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("48e7e144-223c-4093-87cb-4afa5bdd131d"), Type = TextBlockType.Text, Text = "Your eidolon's dedication makes it extremely challenging for your foes to bend its mind. Your eidolon gains a +2 circumstance bonus to saving throws against mental effects, and if they roll a success against such an effect, they get a critical success instead. If you have the shared resolve class feature and your eidolon rolls a critical failure against a mental effect, they get a failure instead."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("2575f639-a597-4d7a-a8c0-c66365688218"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("aa9095ce-e823-421a-b4ef-93fe61b27868"),
                Name = "Devotion Aura",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("9e1561f2-3bf9-43bc-b418-f4be691eb262"), Type = TextBlockType.Text, Text = "After fighting at your side for so long, your eidolon has become as devoted to protecting you and your allies as it is to its original cause. It gains a 20-foot devotion aura, which has the abjuration, aura, and occult traits. Whenever one of your eidolon's allies within the aura takes damage, you can reduce the damage by your eidolon's Constitution modifier. You lose a number of Hit Points equal to half the amount by which the eidolon reduced the damage, rounded down. If the damage was lower than the Constitution modifier, base the damage you take on the actual amount of damage prevented."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("2983c07f-fe31-404c-91ac-8330a2a1baa0"), and =>
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
                Id = Guid.Parse("359f008f-25d3-4ac8-ace1-97c4028f845a"),
                PlaneId = Planes.Instances.EtherealPlane.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af47bf35-480b-4124-8787-4650c9c66c1b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 63
            };
        }
    }
}
