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
        public static readonly Guid ID = Guid.Parse("20a8156d-dad5-4fb4-8df6-ee13deeb08f2");

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
            builder.GainSpecificSpellCasting(Guid.Parse("3ed7898e-1f88-47fd-be0d-1a82add52bc9"), MagicTraditions.Instances.Divine.ID);
        }

        protected override IEnumerable<EidolonVariant> GetVariants()
        {
            yield return new EidolonVariant
            {
                Id = Guid.Parse("5a3d4bd5-8b2c-4a75-b2f1-6dbcb56efed7"),
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
                Id = Guid.Parse("2b241dca-9733-4e18-8d65-6549f96afe05"),
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
                Id = Guid.Parse("18d0c15e-5f46-4dfc-b93f-8821f581363f"),
                Name = "Spirit Touch",
                Level = 1,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("0eb4760b-41af-49b8-9a35-8b377e0e4bc4"), Type = TextBlockType.Text, Text = "Your eidolon's attacks possess a psychopomp's ability to harm the living and the dead. Your eidolon's unarmed Strikes affect incorporeal creatures as though etched with a ghost touch property rune and deal an extra 1 negative damage to living creatures and an extra 1 positive damage to undead."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("ca9997d2-5da5-41c8-9143-a7f8aaeab8c2"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("8a1a2945-5910-4516-b9d9-d9dfbf6ddfc0"),
                Name = "Hidden Watcher",
                Level = 7,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("edc3b0d4-be54-4cd9-8095-bb70313a56dc"), Type = TextBlockType.Text, Text = "Your eidolon can render both of you unseen. Once per hour, it can cast invisibility targeting you, them, or both of you at once. If the spell targeted both of you, the spell ends for both of you if either of you uses a hostile action."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("8bbd75af-44e9-489d-982c-5ed35fc049f0"), and =>
                {
                    //TODO: Add effects.
                })
                .Build()
            };

            yield return new EidolonAbility
            {
                Id = Guid.Parse("ecb3b1af-08f1-49ca-ba68-2bb7921db7e4"),
                Name = "Spirit Taker",
                Level = 17,
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b71dfb9e-46cb-48d4-a3c1-c57dd1091f8f"), Type = TextBlockType.Text, Text = "Your eidolon is particularly capable when it comes to handling bodiless spirits and putting undead to their final rest. Your eidolon can see incorporeal creatures inside of solid objects and can attack them with Strikes without penalty; an incorporeal creature in a solid object that takes damage from your eidolon's Strike is expelled from the object to the nearest available space, moving closer to your eidolon if possible."},
                    new TextBlock {Id = Guid.Parse("ba53de84-acbd-497f-8963-fed54b8737a9"), Type = TextBlockType.Text, Text = "Additionally, your eidolon can target or affect a creature projecting its consciousness (such as via project image) or possessing another creature, even if its body is elsewhere, though your eidolon must know about the possession or projection and choose to do so."},
                    new TextBlock {Id = Guid.Parse("7b33f86c-65f9-47d8-897b-e576abeb75ee"), Type = TextBlockType.Text, Text = "Finally, the spirit of an undead destroyed by your eidolon's Strikes is sent directly to the Boneyard for judgment; an undead with an ability to avoid such a fate automatically, such as a ghost's rejuvenation, can attempt a counteract check against your spell DC to return via that ability as normal. In that case, it uses its Will save modifier as its counteract modifier."},
                },
                Effect = BooleanEffectBuilder.CreateAnd(Guid.Parse("5f4a441d-963d-4848-83f4-ccad425130d3"), and =>
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
                Id = Guid.Parse("c7b22b51-2fb3-41b6-b5ed-7181e1623a90"),
                PlaneId = Planes.Instances.Boneyard.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78086ea1-266a-4c5f-9327-62a5abc7d737"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 66
            };
        }
    }
}
