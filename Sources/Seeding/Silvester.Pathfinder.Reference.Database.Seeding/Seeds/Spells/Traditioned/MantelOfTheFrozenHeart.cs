using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MantelOfTheFrozenHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("a1941a62-b1a4-4701-959d-229498829021");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mantel of the Frozen Heart",
                Level = 5,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c24e6a4a-d337-4ae6-a6e4-ba7f61a7c147"), Type = TextBlockType.Text, Text = "You surround yourself in a mantle of frigid ice magic, and your skin and armor morph into cold blue ice. Freezing air emanates from your body, sending a chill down anyone's spine who draws too close and leaving a fine dusting of frost in your wake. Upon Casting this Spell, pick two of the options below. As a single action, which has the concentrate trait, you can change one of your chosen abilities to a different option from the list." };
            yield return new TextBlock { Id = Guid.Parse("a2794c4a-7f83-4b48-83e0-8055274a1560"), Type = TextBlockType.Enumeration, Text = "Chilling Ice - The ice around your body thickens, melting off to protect you from heat while inuring you from the cold. You gain resistance 10 to cold." };
            yield return new TextBlock { Id = Guid.Parse("40714776-1526-4188-a33f-286825eb10e2"), Type = TextBlockType.Enumeration, Text = "Heart of Ice - Your body temperature plummets to blistering cold. Any creature that touches you, or that hits you with a melee unarmed attack or non-reach melee weapon attack, takes 2d6 cold damage." };
            yield return new TextBlock { Id = Guid.Parse("17d92c36-261d-4dc7-a142-a31cf69a996c"), Type = TextBlockType.Enumeration, Text = "Ice Glide - Ice trails from your feet for an instant as you move, allowing you to skate rapidly along the ice. You don't need to Balance on ice, and you ignore difficult terrain caused by ice or snow. While moving along a smooth surface, you gain a +20-foot status bonus to your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("a6b190ff-25f7-442f-8160-6f3545ee9c44"), Type = TextBlockType.Enumeration, Text = "Icy Claws - Your hands morph into vicious, piercing claws of ice useful for attacking or climbing. As long as you have both hands free, you gain a climb Speed equal to your land Speed. You gain a claw unarmed attack with the agile and finesse traits, in the brawling weapon group. Your claw attack deals 1d6 piercing damage as its base damage, plus an additional 2d6 cold damage." };
        }


        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2550f498-bb8d-420b-9dcf-4ab032970b0b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 115
            };
        }
    }
}
