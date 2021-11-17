using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonGiant : Template
    {
        public static readonly Guid ID = Guid.Parse("9c7839e6-bafb-4978-a026-1c48e12d1d6f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Giant",
                Level = 5,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8d03b5f-9e29-4049-bc22-1090565aac82"), Type = TextBlockType.Text, Text = "You conjure a giant to fight for you. You summon a common creature that has the giant trait and whose level is 5 or lower, such as those found in Pathfinder Bestiary volumes. Heightening the spell increases the maximum level of creature you can summon." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("768f43ca-8234-4d30-9f74-fe31ab9d81fd"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d3470338-1f98-4625-bd23-e16dae852e6d"), Type = TextBlockType.Text, Text = "The summoned creature's level is 1." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("e7be9565-6efa-42ae-8833-d193407c6778"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5f734a89-1a0d-482d-a4ef-d0e4354ed890"), Type = TextBlockType.Text, Text = "The summoned creature's level is 2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("6b4d8904-2848-4e9c-bb07-f030a4fc546d"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("5390f77b-4425-4c8b-a68c-35e8105ba7a0"), Type = TextBlockType.Text, Text = "The summoned creature's level is 3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4d9e4a2b-d131-4565-82f4-441cd1dfd695"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e059b175-4ccd-4d36-a041-068c41cae5e0"), Type = TextBlockType.Text, Text = "The summoned creature's level is 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("af4260a6-bb31-4373-afc0-880e7048cd8f"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cc74cb00-c2ce-40e3-849e-3c28f8d91d65"), Type = TextBlockType.Text, Text = "The summoned creature's level is 7." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a7dd5858-6387-4678-a682-86bc5cf5a1fc"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ccbe1877-affd-4104-a93c-083bcf315557"), Type = TextBlockType.Text, Text = "The summoned creature's level is 9." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("49692b02-0f96-41c1-9561-4ef09d63376e"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("73df3654-1839-4fae-bd71-8452da662db2"), Type = TextBlockType.Text, Text = "The summoned creature's level is 11." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("ba95cb4a-cde5-407a-9159-0ffe9e1eb72b"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("84c39764-55e5-4c00-8e51-6d4aa921d83f"), Type = TextBlockType.Text, Text = "The summoned creature's level is 13." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f9fbe75b-3c9a-414f-a7a2-4348d1d28422"),
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("709a32fa-8d72-4d53-9acb-5048ce5f4305"), Type = TextBlockType.Text, Text = "The summoned creature's level is 15." }
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Primal.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("580fd162-bf72-4f9f-a825-71e081fdc360"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 376
            };
        }
    }
}
