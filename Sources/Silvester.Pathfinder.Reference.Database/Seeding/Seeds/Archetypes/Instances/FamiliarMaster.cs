using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class FamiliarMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "From the wise owl perched on the wizard’s shoulder to the crafty gremlin that serves the witch for their own reasons, the ghastly homunculus in the alchemist’s lab to the clever monkey that picks the lock of the thief’s cell, familiars have always served. Whether through rigorous training or a preternatural connection, yours serves better than most." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 174
            };
        }
    }
}
