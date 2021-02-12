using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ContinualFlameSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Three Actions";
        public override string MagicSchool => "Evocation";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("d253d16d-cbac-4673-a25f-0a3c33173cd1"),
                Name = "Continual Flame",
                Description = "A magical flame springs up from the object, as bright as a torch. It doesn’t need oxygen, react to water, or generate heat.",
                Level = 2,
                Targets = "1 object.",
                Range = 0
            };
        }

        public override IEnumerable<SpellRequirement> GetRequirements()
        {
            yield return new SpellRequirement { Id = Guid.Parse("87a3439f-f230-40e2-8b44-965944f2c288"), Text = "6 gp of ruby dust" };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening { Id = Guid.Parse("fd04a9d3-8d55-49b6-ab6f-863cfda50de7"), Level = 3, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 16gp." };
            yield return new SpellHeightening { Id = Guid.Parse("c15bae80-bafd-4214-a887-e8dc349d2a51"), Level = 4, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 30gp." };
            yield return new SpellHeightening { Id = Guid.Parse("ecdcd196-a2f7-4eff-a302-36829c060875"), Level = 5, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 60gp." };
            yield return new SpellHeightening { Id = Guid.Parse("20e9bfe7-6e9d-4e2d-ae10-68455f7a75dc"), Level = 6, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 120gp." };
            yield return new SpellHeightening { Id = Guid.Parse("70f8b982-3a29-4498-89e7-eee2ead46d0f"), Level = 7, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 270gp." };
            yield return new SpellHeightening { Id = Guid.Parse("26042150-1558-43d2-acd2-8a75c20f513e"), Level = 8, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 540gp." };
            yield return new SpellHeightening { Id = Guid.Parse("79854345-f541-48f2-8e04-8401e71c598b"), Level = 9, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 1350gp." };
            yield return new SpellHeightening { Id = Guid.Parse("fa60eb32-a8f7-4129-ac79-86db2b0c6e85"), Level = 10, Description = "The spell is more difficult to counteract and resist, but the cost is increased to 3350gp." };
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
            yield return "Divine";
            yield return "Occult";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Evocation";
            yield return "Light";
        }
    }
}
