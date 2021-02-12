using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ChromaticWallSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Three Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300"),
                Name = "Chromatic Wall",
                Description = "You create an opaque wall of light in a single vibrant color. The wall is straight and vertical, stretching 60 feet long and 30 feet high. If the wall would pass through a creature, the spell is lost. The wall sheds bright light for 20 feet on each side, and dim light for the next 20 feet. You can ignore the wall’s effects.",
                Level = 5,
                Range = 120,
                Duration = "10 minutes."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("5d6a8acb-12b1-425e-80f5-6166c16c1826"), Text = "Roll 1d4 to determine the color of the wall. Each color has a particular effect on items, effects, or creatures that attempt to pass through. Chromatic wall can’t be counteracted normally; rather, each color is automatically counteracted when targeted by a specific spell, even if that spell’s level is lower than that of chromatic wall." };
            yield return new SpellDetailBlock { Id = Guid.Parse("66f7ae40-6842-4482-b926-73b19f6dd8f9"), Text = "- Red: The wall destroys ranged weapon ammunition (such as arrows and crossbow bolts) that would pass through, and it deals 20 fire damage to anyone passing through, with a basic Reflex save. Cone of cold can counteract a red chromatic wall." };
            yield return new SpellDetailBlock { Id = Guid.Parse("6256a8a8-31ae-4576-aa8c-722662fa37d7"), Text = "- Orange: The wall destroys thrown weapons that would pass through, and it deals 25 acid damage to anyone passing through, with a basic Reflex save. Gust of wind can counteract an orange chromatic wall." };
            yield return new SpellDetailBlock { Id = Guid.Parse("02ad0292-99e0-42e1-a2f8-da387196a90c"), Text = "- Yellow :The wall stops acid, cold, electricity, fire, force, negative, positive, and sonic effects from passing through, and it deals 30 electricity damage to anyone passing through, with a basic Reflex save. Disintegrate can counteract a yellow chromatic wall." };
            yield return new SpellDetailBlock { Id = Guid.Parse("fc855a59-8d6c-44f2-978d-86551ac8ecbc"), Text = "- Green: The wall stops toxins, gases, and breath weapons from passing through. It deals 10 poison damage to anyone passing through and makes them enfeebled 1 for 1 minute. A basic Fortitude save reduces the damage and negates the enfeebled condition on a success. Passwall can counteract a green chromatic wall." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("070c4a22-2028-4361-89b5-ef690dd3fa6b"),
                Level = 7,
                Description = "The spell’s duration increases to 1 hour. Roll 1d8 to determine the wall’s color; the results for 5–8 are below.A red, orange, yellow, or green wall deals an extra 10 damage." ,
                Details = 
                { 
                    new SpellHeighteningDetailBlock { Id = Guid.Parse("15cbcb57-8a87-4384-83cc-d6fd57200b69"), Text = "- Blue: The wall stops auditory, petrification, and visual effects from passing through, and creatures passing through are subject to the effects of flesh to stone. Magic missile can counteract a blue chromatic wall."},
                    new SpellHeighteningDetailBlock { Id = Guid.Parse("64b88f10-e799-4c14-891c-22084ad8ac1c"), Text = "- Indigo: The wall stops divination and mental effects from passing through, and those passing through are subject to the effects of warp mind. Searing light can counteract an indigo chromatic wall."},
                    new SpellHeighteningDetailBlock { Id = Guid.Parse("720a973c-28a7-44c6-b327-7c6e165b306c"), Text = "- Violet: The wall prevents spells from targeting the other side (area effects still cross as normal). Creatures passing through must succeed at a Will save or they are slowed 1 for 1 minute; on a critical failure, the creature is instead sent to another plane, with the effect of plane shift. Dispel magic can counteract a violet chromatic wall."},
                    new SpellHeighteningDetailBlock { Id = Guid.Parse("12927068-2bf4-49b8-bd09-b92c6a3f8169"), Text = "- Reroll, and creatures that pass through the wall take a –2 circumstance penalty to their saves."},
                }
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Abjuration";
        }
    }
}
