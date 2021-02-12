using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectPoisonSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Divination";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("8e4669af-e67c-42a4-bd0f-9e117496cb6c"),
                Name = "Detect Poison",
                Description = "You detect whether a creature is venomous or poisonous, or if an object is poison or has been poisoned. You do not ascertain whether the target is poisonous in multiple ways, nor do you learn the type or types of poison. Certain substances, like lead and alcohol, are poisons and so mask other poisons.",
                Level = 1,
                Range = 30,
                Targets = "1 object or creature"
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("5f67a8e9-f9f4-4b40-a9b6-f651f6b07886"), Level = 2, Description = "You learn the number and types of poison." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Divine";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "Detection";
            yield return "Divination";
        }
    }
}
