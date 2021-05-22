using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ArtisticFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("c52a8124-b2ad-42f4-9716-2a3862a80bb3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Artistic Flourish",
                Level = 4,
                Range = "15 feet.",
                Duration = "10 minutes.",
                Targets = "1 item or work of art that fits entirely within the range.",
                DomainId = Domains.Instances.Creation.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1861d8d-f488-4d53-b7b3-1b2bec0fdb8c"), Type = TextBlockType.Text, Text = "You transform the target to make it match your artisanal and artistic vision. If you have expert proficiency in Crafting, the item grants a +1 item bonus to attack rolls if it’s a weapon or skill checks if it’s a skill tool. The target is a beautiful and impressive piece for its new quality, but the effect is obviously temporary, so its monetary value doesn’t change." };
            yield return new TextBlock { Id = Guid.Parse("d25e4d33-ec61-418f-bb45-ef9d8848e598"), Type = TextBlockType.Text, Text = "When you cast this spell, any previous artistic flourish you had cast ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ecd6a6c5-1594-45b7-8d19-5be6b6e0d926"),
                Level = "+7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("24c437a7-1c8c-4065-ba38-3f3d5674657b"), Type = TextBlockType.Text, Text = "If you have master proficiency in Crafting, the item grants a +2 item bonus instead." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("671f7aed-f6d9-4eb9-95f6-029e3df45739"),
                Level = "+10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d2d47163-5fcb-4f8d-9cc6-e42e29e12a7b"), Type = TextBlockType.Text, Text = "If you have legendary proficiency in Crafting, the item grants a +3 item bonus instead." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7a7cfab-329c-4b71-8155-f1807e6c64d1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
