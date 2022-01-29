using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonAxiom : Template
    {
        public static readonly Guid ID = Guid.Parse("7eab7d0d-8445-470b-bf1c-243bfb027bf5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Axiom",
                Level = 5,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1155bc59-658a-4baf-ad36-178e873fdbb3"), Type = TextBlockType.Text, Text = "You conjure a lawful celestial, monitor, or fiend to fight on your behalf. You summon a common lawful creature that has the celestial, monitor, or fiend trait and whose level is 5 or lower. You can't summon a creature unless its alignment is one of your deity's preferred alignments (or, if you don't have a deity, is within one step of your alignment). At the GM's discretion, some deities might restrict specific types of creatures, even if their alignments match. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9ce18e85-d8d4-45eb-925a-64bb97e9be43"),
                Level = "6th",
                Details = new TextBlock[]
                  {
                    new TextBlock {Id = Guid.Parse("bef52b99-98ed-44f6-8baf-fafd60ac7355"), Type = TextBlockType.Text, Text = "Level 7." }
                  }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("96c323ab-a283-486b-80d6-e0ccc2375ad2"),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ea2c047e-b757-453d-a0ec-773fc73a5694"), Type = TextBlockType.Text, Text = "Level 79" }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("7b45de19-90c5-4445-973c-dfdbab805e6b"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("089c2688-9f9c-4ff2-8e15-9aea20e5e6cb"), Type = TextBlockType.Text, Text = "Level 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4a00b370-e6a2-43c1-a334-fd4d22e301a2"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("182bc4aa-84b1-4169-af5a-c7d31bdf84e8"), Type = TextBlockType.Text, Text = "Level 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9f21a6b2-55a4-46eb-9594-996932c69f8c"),
                Level = "10th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5aeb549e-b1d7-4e16-bb2a-5747601bbfc5"), Type = TextBlockType.Text, Text = "Level 15." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7e80d4db-011e-40e9-ad5d-564a57ce5cca"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("132e1deb-7bfe-4ea8-b655-3a8963b0aa45"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 131
            };
        }
    }
}
