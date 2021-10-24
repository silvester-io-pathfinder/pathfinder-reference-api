using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Archer : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Archer",
                DedicationFeatId = Feats.Instances.ArcherDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Bows of all types are powerful weapons. Generals and hunters alike recognize the power in dealing death from long distances, and from behind cover. Those dedicated to the bow—from mysterious cloaked strangers to heartless snipers—are often viewed with a mixture of respect and fear. Like any weapon adept, the archer’s skill is forged through experience and constant practice. A true archer becomes one with the bow and is able to accomplish with that weapon things that most would consider impossible, or at least nearly magical." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 157
            };
        }
    }
}
