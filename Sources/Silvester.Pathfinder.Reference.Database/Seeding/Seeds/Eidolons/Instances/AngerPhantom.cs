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
        public static readonly Guid ID = Guid.Parse("");

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
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Occult.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
                Name = "Furious Strike",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can infuse an attack with unmitigated rage. It gains the Furious Strike activity."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.FuriousStrike.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Seething Frenzy",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can stoke itself into a frenzy. It gains the Seething Frenzy action."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.SeethingFrenzy.ID);
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Anger Aura",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon exudes wrath in an aura around it, rousing the ire of nearby creatures and causing their defenses to crack as they seethe with rage. Your eidolon gains a 20-foot anger aura, which has the aura, emotion, enchantment, mental, and occult traits. The resistances of any creature in the aura, including you, your allies, your enemies, and your eidolon, are reduced by an amount equal to 3 + your eidolon's Constitution modifier. Your eidolon can hold in its rage by spending a single action, which has the concentrate trait. This reduces the aura's effect to affect only your eidolon. It can take this action again to reinstate the full effect of its aura. Creatures in a barbarian Rage, Seething Frenzy, or similar ability that allows them to channel their anger aren't affected by the anger aura."},
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
                PlaneId = Planes.Instances.EtherealPlane.ID
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
