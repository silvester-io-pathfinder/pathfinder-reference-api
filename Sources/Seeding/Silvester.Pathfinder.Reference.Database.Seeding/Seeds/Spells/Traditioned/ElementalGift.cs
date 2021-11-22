using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalGift : Template
    {
        public static readonly Guid ID = Guid.Parse("b2e7ce5b-2d9b-496e-a8cc-d8b6483efdd5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Gift",
                Level = 4,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d771469-ee33-4b58-b56f-ffc0f5fe8edb"), Type = TextBlockType.Text, Text = "An elemental force fills your target, granting the target the swiftness of air, the ruggedness of earth, the sting of fire, or the flexibility of water, depending on which element you choose. Choose an element when you Cast the Spell. The target gains the benefit of that element as described below, and this spell gains that trait�s element." };
            yield return new TextBlock { Id = Guid.Parse("d6719822-d7ec-4a19-9a71-75a3fabe3fa2"), Type = TextBlockType.Enumeration, Text = "Air - The target gains a +30-foot status bonus to its land Speed and gains a fly Speed equal to its land Speed without the status bonus." };
            yield return new TextBlock { Id = Guid.Parse("f6972dfd-c81f-4e1b-babe-bd55853c9dab"), Type = TextBlockType.Enumeration, Text = "Earth - While on the ground, the target gets a +2 status bonus to Fortitude and Reflex saves against effects that would Shove or Trip it, and to saves against effects that would attempt to knock it prone. In addition, the ground adjacent to the target is difficult terrain, and the difficult terrain moves with the target, though the target ignores this difficult terrain with its own movement." };
            yield return new TextBlock { Id = Guid.Parse("a94908f4-0bdb-4caa-8b32-27ab761bde06"), Type = TextBlockType.Enumeration, Text = "Fire - The target�s melee unarmed Strikes and melee weapon Strikes deal 1d6 persistent fire damage on a hit." };
            yield return new TextBlock { Id = Guid.Parse("a85816e6-0273-48ff-963b-54308508c11d"), Type = TextBlockType.Enumeration, Text = "Water - The target takes on a watery sheen, gaining resistance 5 to fire and a swim Speed equal to its land Speed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1e781e87-bc1a-4319-ba5c-08a6f387fbcd"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("7dba7998-993a-4ce4-8f1f-3448731a8989"), Type = TextBlockType.Text, Text = "You can target up to 5 willing creatures." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("caa75cd1-6d26-4ce6-8664-e0a2ce198a5a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 103
            };
        }
    }
}
