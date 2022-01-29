using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Magus : Template
    {
        public static readonly Guid ID = Guid.Parse("796f39b1-e553-4186-b335-b9c943e384f4");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Magus",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.MagusDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("40c7b4ba-da01-41bb-981b-a4d5caec4f94"), Type = TextBlockType.Text, Text = "you've mixed physical combat with spellcasting." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("363db136-bb80-45be-87e1-3b5c92360537"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 75
            };
        }
    }
}
