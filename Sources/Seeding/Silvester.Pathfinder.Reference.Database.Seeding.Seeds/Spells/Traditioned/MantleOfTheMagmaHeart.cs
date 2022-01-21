using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MantleOfTheMagmaHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("261bd102-580e-4c4a-b15b-089fb32820c4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mantle of the Magma Heart",
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
            yield return new TextBlock { Id = Guid.Parse("3d235ddb-5445-48e2-aa9a-82bf24d321b9"), Type = TextBlockType.Text, Text = "You surround yourself in a mantle of blazing fire magic, and your skin and anything you're wearing morphs into burning hot lava. The air around you swelters with heat, and tiny sparks of flame dance behind you as you pass. Upon casting this spell, pick two of the options below. As a single action, which has the concentrate trait, you can change one of your chosen abilities to a different option from the list." };
            yield return new TextBlock { Id = Guid.Parse("0367417d-1070-4625-bea8-44da912d9560"), Type = TextBlockType.Enumeration, Text = "Enlarging Eruption - You erupt in lava, which clings to you and hardens, causing your body to swell and burst until you grow to size Large. You're clumsy 1. Your reach increases by 5 feet (or by 10 feet if you started out Tiny), and you gain a +2 status bonus to melee damage. You can't choose this option if you're already Large or larger." };
            yield return new TextBlock { Id = Guid.Parse("2ffb03b1-8ee5-4406-aa04-9e38fb32247c"), Type = TextBlockType.Enumeration, Text = "Fiery Grasp - Your hands swell and grow with lava. You gain a lava fist unarmed attack in the brawling weapon group. Your lava fists deal 1d8 bludgeoning damage as their base damage, plus an additional 2d6 fire damage and 1d6 persistent fire damage." };
            yield return new TextBlock { Id = Guid.Parse("39801073-4214-442b-85f1-73efbcc72d26"), Type = TextBlockType.Enumeration, Text = "Heart of Fire - Your body's temperature becomes so hot that any creature that touches you, or that hits you with a melee unarmed attack or non-reach melee weapon attack, takes 2d6 fire damage." };
            yield return new TextBlock { Id = Guid.Parse("aaffae43-c894-4ef7-ba5c-eb76e4032e95"), Type = TextBlockType.Enumeration, Text = "Warming Flames - Flames flicker around you, warming away the cold while protecting you from the heat. You gain resistance 5 to cold and fire." };
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
            builder.Add(Guid.Parse("4d65decf-b5bc-4199-a72d-1e3f9e83fac1"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("85626e8f-5a0e-4e72-9239-df04b68a90d4"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("33dd861d-9dff-40c7-9bb3-84353d239ea5"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29292150-d845-45a3-91fb-c8ca5be4fb75"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 115
            };
        }
    }
}
