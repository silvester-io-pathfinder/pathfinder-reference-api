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
    public class Psychopomp : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Eidolon GetEidolon()
        {
            return new Eidolon
            {
                Id = ID, 
                Name = "Psychopomp",
                Description = "Your eidolon is a psychopomp, a creature whose sworn duty is to usher souls safely to the afterlife and maintain the courts of the dead. Psychopomp eidolons have a variety of appearances, but since they often traffic with mortals, their form typically includes an elaborate mask. You and your psychopomp eidolon share an important fate together, whether it relates directly to your own soul or to a mission that will somehow protect the souls of others.",
                SuggestedAttacks = "beak (piercing), claw (slashing), fist (bludgeoning), jaws (piercing), unarmed attacks shaped like a weapon",
                LanguageId = Languages.Instances.Requian.ID,
                MagicTraditionId = MagicTraditions.Instances.Divine.ID,
            };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.TrueNeutral.ID;
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
            yield return Traits.Instances.Eidolon.ID;
            yield return Traits.Instances.Monitor.ID;
            yield return Traits.Instances.Psychopomp.ID;
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
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
                Name = "Scribe of the Dead",
                Strength = 12,
                Dexterity = 18,
                Constitution = 12,
                Intelligence = 14,
                Wisdom = 12,
                Charisma = 10,
                ArmorClass = 1,
                DexterityCap = 4
            };

            yield return new EidolonVariant
            {
                Id = Guid.Parse(""),
                Name = "Soul Guardian",
                Strength = 18,
                Dexterity = 14,
                Constitution = 16,
                Intelligence = 10,
                Wisdom = 12,
                Charisma = 8,
                ArmorClass = 2,
                DexterityCap = 3
            };
        }

        protected override IEnumerable<EidolonAbility> GetAbilities()
        {
            yield return new EidolonAbility
            {
                Id = Guid.Parse(""),
                Name = "Spirit Touch",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon's attacks possess a psychopomp's ability to harm the living and the dead. Your eidolon's unarmed Strikes affect incorporeal creatures as though etched with a ghost touch property rune and deal an extra 1 negative damage to living creatures and an extra 1 positive damage to undead."},
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
                Name = "Hidden Watcher",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon can render both of you unseen. Once per hour, it can cast invisibility targeting you, them, or both of you at once. If the spell targeted both of you, the spell ends for both of you if either of you uses a hostile action."},
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
                Name = "Spirit Taker",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your eidolon is particularly capable when it comes to handling bodiless spirits and putting undead to their final rest. Your eidolon can see incorporeal creatures inside of solid objects and can attack them with Strikes without penalty; an incorporeal creature in a solid object that takes damage from your eidolon's Strike is expelled from the object to the nearest available space, moving closer to your eidolon if possible."},
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Additionally, your eidolon can target or affect a creature projecting its consciousness (such as via project image) or possessing another creature, even if its body is elsewhere, though your eidolon must know about the possession or projection and choose to do so."},
                    new TextBlock {Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Finally, the spirit of an undead destroyed by your eidolon's Strikes is sent directly to the Boneyard for judgment; an undead with an ability to avoid such a fate automatically, such as a ghost's rejuvenation, can attempt a counteract check against your spell DC to return via that ability as normal. In that case, it uses its Will save modifier as its counteract modifier."},
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
                PlaneId = Planes.Instances.Boneyard.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 66
            };
        }
    }
}
