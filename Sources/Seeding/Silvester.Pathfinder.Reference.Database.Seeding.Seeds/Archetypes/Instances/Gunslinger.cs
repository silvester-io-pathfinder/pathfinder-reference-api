using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Gunslinger : Template
    {
        public static readonly Guid ID = Guid.Parse("49d770d5-a148-4c06-9657-d1d48cd11a3b");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Gunslinger",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.GunslingerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("de42755d-b480-436d-9c3b-3c17aae590cc"), Type = TextBlockType.Text, Text = "You like a weapon that makes an impression almost as much as you like making an impression." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d3f245a1-26d8-4298-a34b-87216e07e91e"), Type = TextBlockType.Text, Text = "Gunslinger is a great fit for dexterous characters who want a weapon that hits hard from a distance, especially rangers and rogues who already have abilities that can make their first hit count. Spellcasters with true strike might favor firearms with the fatal property and gunslinger abilities that improve options for supporting their allies." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85e5c0db-ee9c-4b71-af25-2c24945a535f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 127
            };
        }
    }
}
