using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class IllusoryScene : Template
    {
        public static readonly Guid ID = Guid.Parse("78c42004-5f32-428c-8d6c-707bff4bc431");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Illusory Scene",
                Level = 5,
                CastTime = "10 minutes.",
                Range = "500 feet.",
                Area = "30-foot burst.",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3b73320-5387-4514-9fd0-1239eb887164"), Type = TextBlockType.Text, Text = "You form an imaginary scene that includes up to 10 discrete creatures or objects of various sizes, all of which must be within the spell's area. These elements generate appropriate sounds and smells, and they feel right to the touch. Elements of an illusory scene are incapable of speech. Unlike with the illusory creature spell, creatures in your scene lack combat abilities and statistics. Your scene doesn't include changes to the environment around it, though you can place your scene within the illusory environment of a hallucinatory terrain spell." };
            yield return new TextBlock { Id = Guid.Parse("35534e8b-d294-48d3-a9d7-47278a67b926"), Type = TextBlockType.Text, Text = "When you create the scene, you can choose to have it be static or follow a program. Though a static scene is stationary, it includes basic natural movement. For example, wind blowing on an illusory piece of paper would rustle it. A program can be up to 1 minute long and repeats when finished. For instance, you could create a scene of two orcs fighting each other, and the fight would go the same way for each repetition. If you create a loop, the two fighters end up in the same place at the start of the scene and at the end of it, but you can smooth the program so it's hard to tell when the loop ends and begins. Anyone observing the scene for more than a few minutes almost always notices it looping. You're unable to alter the program after you create the illusion." };
            yield return new TextBlock { Id = Guid.Parse("a7dead75-0040-4c46-a398-bbc701e754d7"), Type = TextBlockType.Text, Text = "Any creature that touches any part of the image or uses the Seek action to examine it can attempt to disbelieve your illusion. If they interact with a portion of the illusion, they disbelieve only that portion. They disbelieve the entire scene only on a critical success." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("30f3a7e9-decc-4b69-bd1b-7ea1613840f6"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fc9c5991-c12f-48ef-a401-823531491782"), Type = TextBlockType.Text, Text = "Creatures or objects in your scene can speak. You must speak the specific lines for each actor when creating your program. The spell disguises your voice for each actor." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("1763b47c-23f2-4ac7-bc07-8373e301e1d3"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3679ee77-2188-404b-aaa0-327180b9558c"), Type = TextBlockType.Text, Text = "As the 6th-level version, and the duration is unlimited." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Olfactory.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35bc52fe-2c57-4cdd-bf4b-aad10dc6c87c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 345
            };
        }
    }
}
