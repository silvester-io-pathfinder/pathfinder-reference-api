using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class FamiliarMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("ef8d9637-c343-4187-9cfd-1f741cf076ae");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Familiar Master",
                DedicationFeatId = Feats.Instances.FamiliarMasterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f236303d-5dd0-4c4b-864a-44d2fc4c7d82"), Type = TextBlockType.Text, Text = "From the wise owl perched on the wizard's shoulder to the crafty gremlin that serves the witch for their own reasons, the ghastly homunculus in the alchemist's lab to the clever monkey that picks the lock of the thief's cell, familiars have always served. Whether through rigorous training or a preternatural connection, yours serves better than most." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0ff5533-8b5f-4930-b277-5e4d231a3e68"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 174
            };
        }
    }
}
