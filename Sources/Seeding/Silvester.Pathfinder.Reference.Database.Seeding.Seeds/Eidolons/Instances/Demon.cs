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
    public class Demon : Template
    {
        public static readonly Guid ID = Guid.Parse("bbb9b662-d0e6-400d-a58f-499eeed77dd4");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Demon",
                Description = "Your eidolon is a demon, born of mortal sin congealed amid the chaos and evil of the Abyss, using its link to you to spread chaos at your side. Choose an associated sin for your demon. Demon eidolons have appearances as varied as the infinite Abyss. While demons are inherently untrustworthy, your demon eidolon has reached an accord with you and generally keeps it, though that doesn't mean your eidolon isn't actively working to bring your life deeper into its associated sin. Though a true demon, your demon eidolon's link to you as a mortal prevents them from casting the abyssal pact ritual, even if they somehow learn it.",
                SuggestedAttacks = "claw (slashing), jaws (piercing), horn (piercing), tail (bludgeoning), tentacle (bludgeoning), wing (bludgeoning)",
                LanguageId = Languages.Instances.Abyssal.ID,
                MagicTraditionId = MagicTraditions.Instances.Divine.ID,
            };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override IEnumerable<Guid> GetSenses()
        {
            yield return Senses.Instances.Darkvision.ID;
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
            yield return Skills.Instances.Religion.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Demon.ID;
            yield return Traits.Instances.Eidolon.ID;
            yield return Traits.Instances.Fiend.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("72c93b9a-7fd7-4caa-8d04-4705cbfacebe"), MagicTraditions.Instances.Divine.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("a4d5c10c-e21a-483d-855f-41d817d892a4"),
                Name = "Tempter Demon",
                Strength = 12,
                Dexterity = 18,
                Constitution = 12,
                Intelligence = 10,
                Wisdom = 10,
                Charisma = 16,
                ArmorClass = 1,
                DexterityCap = 4
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse("1b242695-5e37-4731-96cc-3d128688abaa"),
                Name = "Wrecker Demon",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 10,
                Wisdom = 8,
                Charisma = 12,
                ArmorClass = 2,
                DexterityCap = 3
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse("db7feda1-f509-4cd3-b124-0dae6da98042"),
                Name = "Demonic Strikes",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("d7d5b571-56d2-408a-984e-f6838896d613"), Type = TextBlockType.Text, Text = "Your eidolon's attacks are corrupted by the Abyss and imbued with pure evil and shifting chaos. All your eidolon's unarmed Strikes deal an extra 1 evil damage; as usual, this extra damage harms only good creatures or those with a weakness to evil damage. Additionally, choose one of your eidolon's unarmed attacks that deals physical damage; it gains the versatile trait for a different type of physical damage you choose."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("e8c770c1-7d70-49e9-8dd4-084775e5bb8f"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("ce5da4d3-0598-426d-9301-8c3de537fad0"),
                Name = "Visions of Sin",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("7b9661a3-6f01-49e7-9cc6-d94575ebdccd"), Type = TextBlockType.Text, Text = "Your demon is born of sin and can project the sin it is formed from into the minds of others. It gains the Visions of Sin activity"},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("5c6ebe57-a75d-4b46-bc21-62e541e3b039"), and =>
                {
                    and.GainSpecificFeat(Guid.Parse("0af9ee98-84ae-4651-9236-309a52bb0568"), Feats.Instances.VisionsOfSin.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("2093c07c-da4f-40f8-9be6-95b22a922a38"),
                Name = "Blasphemous Decree",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("bece54c4-77db-4cd0-a974-f74ffc71be0b"), Type = TextBlockType.Text, Text = "Your demon utters indescribable words writhing with its associated sin. It can cast an evil divine decree once per day as a 9th-level spell. You are unaffected by this decree, even if you aren't evil. At 19th level, this becomes a 10th-level divine decree instead."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("b416e844-fc8d-4fa4-8b81-893206a2a2f2"), and =>
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
                Id = Guid.Parse("07db9892-9108-4305-944e-4d77da6f418d"),
                PlaneId = Planes.Instances.Abyss.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a54cd5c9-4e4d-4df7-804a-3cb85a1fe83f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page =  62
            };
        }
    }
}
