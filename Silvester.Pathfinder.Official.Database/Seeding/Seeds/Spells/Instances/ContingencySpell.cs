using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ContingencySpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("94beacae-4765-499c-b93e-934fff8585a4"),
                Name = "Contingency",
                Description = "You prepare a spell that will trigger later. While casting contingency, you also cast another spell of 4th level or lower with a casting time of no more than 3 actions. This companion spell must be one that can affect you. You must make any decisions for the spell when you cast contingency, such as choosing a damage type for resist energy. During the casting, choose a trigger under which the spell will be cast, using the same restrictions as for the trigger of a Ready action. Once contingency is cast, you can cause the companion spell to come into effect as a reaction with that trigger. It affects only you, even if it would affect more creatures. If you define complicated conditions, as determined by the GM, the trigger might fail. If you cast contingency again, the newer casting supersedes the older.",
                Level = 7,
                CastTime = TimeSpan.FromMinutes(10),
                Duration = "24 hour."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("d896e7f8-a52e-49d1-a1fe-98148ba1c246"), Level = 8, Description = "You can choose a spell of 5th level or lower." };
            yield return new SpellHeightening { Id = Guid.Parse("cda1fc96-7b2c-4df9-b65f-04b4a2e0f5c7"), Level = 9, Description = "You can choose a spell of 6th level or lower." };
            yield return new SpellHeightening { Id = Guid.Parse("3f51f72d-37e7-4e37-8f3d-48686460b573"), Level = 10, Description = "You can choose a spell of 7th level or lower." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Abjuration";
        }
    }
}
