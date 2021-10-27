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
        public static readonly Guid ID = Guid.Parse("");

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
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Divine.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
                Name = "Demonic Strikes",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon's attacks are corrupted by the Abyss and imbued with pure evil and shifting chaos. All your eidolon's unarmed Strikes deal an extra 1 evil damage; as usual, this extra damage harms only good creatures or those with a weakness to evil damage. Additionally, choose one of your eidolon's unarmed attacks that deals physical damage; it gains the versatile trait for a different type of physical damage you choose."},
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
                Name = "Visions of Sin",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your demon is born of sin and can project the sin it is formed from into the minds of others. It gains the Visions of Sin activity"},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.VisionsOfSin.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Blasphemous Decree",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your demon utters indescribable words writhing with its associated sin. It can cast an evil divine decree once per day as a 9th-level spell. You are unaffected by this decree, even if you aren't evil. At 19th level, this becomes a 10th-level divine decree instead."},
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
                PlaneId = Planes.Instances.Abyss.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page =  62
            };
        }
    }
}
