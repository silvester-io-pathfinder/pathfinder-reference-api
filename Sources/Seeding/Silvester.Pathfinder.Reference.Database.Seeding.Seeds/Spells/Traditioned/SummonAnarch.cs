using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonAnarch : Template
    {
        public static readonly Guid ID = Guid.Parse("a9e3f8c0-4122-4e32-bbe8-75223893d083");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Anarch",
                Level = 5,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a295589-4829-499f-af31-78a4060bb392"), Type = TextBlockType.Text, Text = "You conjure a chaotic celestial, monitor, or fiend to fight on your behalf. You summon a common chaotic creature that has the celestial, monitor, or fiend trait and whose level is 5 or lower. You can't summon a creature unless its alignment is one of your deity's preferred alignments (or, if you don't have a deity, is within one step of your alignment). At the GM's discretion, some deities might restrict specific types of creatures, even if their alignments match. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("376e0f4d-bc46-44a1-8a98-75f339e1a622"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("e2c3f82e-763b-48e7-98c8-b2b76b869564"), Type = TextBlockType.Text, Text = "Level 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9cf43934-7ecc-487a-bee9-0dbc4b6d96e7"),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("25eff160-7b87-4f2b-a836-f87259f1d48a"), Type = TextBlockType.Text, Text = "Level 79" }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("d84d31c6-9174-4ed3-8620-aef24b3bdd95"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("dcb288fd-67b1-4434-9687-66a1840f04d1"), Type = TextBlockType.Text, Text = "Level 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("3a99c84a-e0a8-4ee7-94c0-6b51cfec124a"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("53236886-d739-40aa-8fd3-9ca67e642353"), Type = TextBlockType.Text, Text = "Level 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("cfdd743a-3437-4bc9-b2e7-32d371b7c1e7"),
                Level = "10th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5e8a8ec7-f893-4a44-ad78-2ad319f7273a"), Type = TextBlockType.Text, Text = "Level 15." }
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
            builder.Add(Guid.Parse("3d658dbe-2819-4af0-9aa0-84449446275b"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a242a7df-a930-45c0-94cf-5fad01a1e528"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 131
            };
        }
    }
}
