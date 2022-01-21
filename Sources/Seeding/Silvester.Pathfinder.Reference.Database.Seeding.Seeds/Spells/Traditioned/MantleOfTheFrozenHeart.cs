using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MantleOfTheFrozenHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("e760b746-e1ac-44ff-bece-16417854aa9f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mantle of the Frozen Heart",
                Level = 5,
                Duration = "1 minute.",
                IsDismissable = false,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc7e14b2-b7c1-4297-b2c1-d3b3410fbb8c"), Type = TextBlockType.Text, Text = "You surround yourself in a mantle of frigid ice magic, and your skin and armor morph into cold blue ice. Freezing air emanates from your body, sending a chill down anyone's spine who draws too close and leaving a fine dusting of frost in your wake. Upon Casting this Spell, pick two of the options below. As a single action, which has the concentrate trait, you can change one of your chosen abilities to a different option from the list." };
            yield return new TextBlock { Id = Guid.Parse("11b85e5c-a836-4313-8701-083da0a639e4"), Type = TextBlockType.Enumeration, Text = "Chilling Ice - The ice around your body thickens, melting off to protect you from heat while inuring you from the cold. You gain resistance 10 to cold." };
            yield return new TextBlock { Id = Guid.Parse("4f350c86-ba35-48cf-8281-9d2205ff84c2"), Type = TextBlockType.Enumeration, Text = "Heart of Ice - Your body temperature plummets to blistering cold. Any creature that touches you, or that hits you with a melee unarmed attack or non-reach melee weapon attack, takes 2d6 cold damage." };
            yield return new TextBlock { Id = Guid.Parse("11e3b4ae-cc4f-4bc4-8650-8cf37d1f6600"), Type = TextBlockType.Enumeration, Text = "Ice Glide - Ice trails from your feet for an instant as you move, allowing you to skate rapidly along the ice. You don't need to Balance on ice, and you ignore difficult terrain caused by ice or snow. While moving along a smooth surface, you gain a +20-foot status bonus to your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("9432f016-bdd2-4d9c-af75-78f733d09521"), Type = TextBlockType.Enumeration, Text = "Icy Claws - Your hands morph into vicious, piercing claws of ice useful for attacking or climbing. As long as you have both hands free, you gain a climb Speed equal to your land Speed. You gain a claw unarmed attack with the agile and finesse traits, in the brawling weapon group. Your claw attack deals 1d6 piercing damage as its base damage, plus an additional 2d6 cold damage." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b1d8fd6d-f5fb-43e8-a863-43bbe62fd399"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("20a17d10-15de-4ceb-88eb-707358ee9f45"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("b30325dc-feb0-4987-80d2-2fa67adf1ba1"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d11d89e1-ff5b-4c63-8655-42d69d67deb9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 115
            };
        }
    }
}
