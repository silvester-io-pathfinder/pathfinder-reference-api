using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChromaticWall : Template
    {
        public static readonly Guid ID = Guid.Parse("8c5da2eb-3188-4c3b-82ab-cae8d4e3c300");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chromatic",
                Level = 5,
                Range = "120 feet.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7d606b3-9816-4cf5-ad29-fcbb589fa9c6"), Type = Utilities.Text.TextBlockType.Text, Text = "You create an opaque wall of light in a single vibrant color. The wall is straight and vertical, stretching 60 feet long and 30 feet high. If the wall would pass through a creature, the spell is lost. The wall sheds bright light for 20 feet on each side, and dim light for the next 20 feet. You can ignore the wall’s effects." };
            yield return new TextBlock { Id = Guid.Parse("5d6a8acb-12b1-425e-80f5-6166c16c1826"), Type = Utilities.Text.TextBlockType.Text, Text = "Roll 1d4 to determine the color of the wall. Each color has a particular effect on items, effects, or creatures that attempt to pass through. Chromatic wall can’t be counteracted normally; rather, each color is automatically counteracted when targeted by a specific spell, even if that spell’s level is lower than that of chromatic wall." };
            yield return new TextBlock { Id = Guid.Parse("66f7ae40-6842-4482-b926-73b19f6dd8f9"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "1 - Red: The wall destroys ranged weapon ammunition (such as arrows and crossbow bolts) that would pass through, and it deals 20 fire damage to anyone passing through, with a basic Reflex save. Cone of cold can counteract a red chromatic wall." };
            yield return new TextBlock { Id = Guid.Parse("6256a8a8-31ae-4576-aa8c-722662fa37d7"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "2 - Orange: The wall destroys thrown weapons that would pass through, and it deals 25 acid damage to anyone passing through, with a basic Reflex save. Gust of wind can counteract an orange chromatic wall." };
            yield return new TextBlock { Id = Guid.Parse("02ad0292-99e0-42e1-a2f8-da387196a90c"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "3 - Yellow :The wall stops acid, cold, electricity, fire, force, negative, positive, and sonic effects from passing through, and it deals 30 electricity damage to anyone passing through, with a basic Reflex save. Disintegrate can counteract a yellow chromatic wall." };
            yield return new TextBlock { Id = Guid.Parse("fc855a59-8d6c-44f2-978d-86551ac8ecbc"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "4 - Green: The wall stops toxins, gases, and breath weapons from passing through. It deals 10 poison damage to anyone passing through and makes them enfeebled 1 for 1 minute. A basic Fortitude save reduces the damage and negates the enfeebled condition on a success. Passwall can counteract a green chromatic wall." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("070c4a22-2028-4361-89b5-ef690dd3fa6b"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("10b435c4-4477-4d2c-87fd-cbaf49922875"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell’s duration increases to 1 hour. Roll 1d8 to determine the wall’s color; the results for 5–8 are below.A red, orange, yellow, or green wall deals an extra 10 damage." },
                    new TextBlock { Id = Guid.Parse("452116b2-0f16-4406-bad2-f58af1c80800"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "5 - Blue: The wall stops auditory, petrification, and visual effects from passing through, and creatures passing through are subject to the effects of flesh to stone. Magic missile can counteract a blue chromatic wall." },
                    new TextBlock { Id = Guid.Parse("84a5c2bc-0363-4a18-8b1e-db9d15ec5bd2"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "6 - Indigo: The wall stops divination and mental effects from passing through, and those passing through are subject to the effects of warp mind. Searing light can counteract an indigo chromatic wall." },
                    new TextBlock { Id = Guid.Parse("f9b3866a-ab6c-4138-880c-b1922c5a29fc"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "7 - Violet: The wall prevents spells from targeting the other side (area effects still cross as normal). Creatures passing through must succeed at a Will save or they are slowed 1 for 1 minute; on a critical failure, the creature is instead sent to another plane, with the effect of plane shift. Dispel magic can counteract a violet chromatic wall." },
                    new TextBlock { Id = Guid.Parse("64fd4ed4-03f0-43e9-9b80-e5bc8a5d28a4"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "8 - Reroll, and creatures that pass through the wall take a –2 circumstance penalty to their saves." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0013706-83d6-4211-b771-594d2c128e1a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 323
            };
        }
    }
}
