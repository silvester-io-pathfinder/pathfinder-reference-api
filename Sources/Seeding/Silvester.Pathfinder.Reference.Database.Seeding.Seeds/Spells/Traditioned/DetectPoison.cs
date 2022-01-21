using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("8e4669af-e67c-42a4-bd0f-9e117496cb6c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Detect Poison",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 object or creature",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c2ce407-d0ba-4516-9420-836238b172c1"), Type = Utilities.Text.TextBlockType.Text, Text = "You detect whether a creature is venomous or poisonous, or if an object is poison or has been poisoned. You do not ascertain whether the target is poisonous in multiple ways, nor do you learn the type or types of poison. Certain substances, like lead and alcohol, are poisons and so mask other poisons." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("5f67a8e9-f9f4-4b40-a9b6-f651f6b07886"), 
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ff710d1a-0b56-42b5-8e50-3892de1914bb"), Type = Utilities.Text.TextBlockType.Text, Text = "You learn the number and types of poison." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8df57877-a3f2-4e38-be72-95566e9ed6e4"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c36e2120-e8ad-4611-aff6-b9b497d1b9ac"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("a3b0c53a-a51f-4adf-a89e-72387f428193"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d14d2a08-04e3-424a-81b8-c32c1fe85fc3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
