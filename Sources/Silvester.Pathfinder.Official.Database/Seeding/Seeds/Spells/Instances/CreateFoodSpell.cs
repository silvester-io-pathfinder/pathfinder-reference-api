using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CreateFoodSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Conjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("2d0fa5a4-eab0-4eca-85cb-23241e5ef814"),
                Name = "Create Food",
                Description = "You create enough food to feed six Medium creatures for a day. This food is bland and unappealing, but it is nourishing. After 1 day, if no one has eaten the food, it decays and becomes inedible. Most Small creatures eat one-quarter as much as a Medium creature (one-sixteenth as much for most Tiny creatures), and most Large creatures eat 10 times as much (100 times as much for Huge creatures and so on).",
                Level = 2,
                CastTime = TimeSpan.FromHours(1),
                Range = 30
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("923762df-f025-49e3-9f23-b82e97f15e5a"), Level = 4, Description = "You can feed 12 Medium creatures." };
            yield return new SpellHeightening { Id = Guid.Parse("14353fce-2884-4203-ae5c-2a52cc7c629b"), Level = 6, Description = "You can feed 50 Medium creatures." };
            yield return new SpellHeightening { Id = Guid.Parse("d5f956fa-1486-461c-9ff5-94db3f1f5cdd"), Level = 8, Description = "You can feed 200 Medium creatures." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Divine";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Conjuration";
        }
    }
}
