using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Investigator : Template
    {
        public static readonly Guid ID = Guid.Parse("3ee44685-c13d-4dd3-b94c-fcc7fd0b7b16");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Investigator",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.InvestigatorDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0c850b46-b879-44cf-8c95-9d0dee919e76"), Type = TextBlockType.Text, Text = "you've developed a keen eye for investigating mysteries." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c3a93136-4c4a-42e8-a8f0-be972e19ad16"), Type = TextBlockType.Text, Text = "The investigator archetype is a good choice for a character that wants deeper investigations or to plan out their turns in advance; it's a particularly good match for Intelligence-based characters like alchemists, witches, and wizards." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2a3b873-9ce7-4fd0-8b6d-40fe2022e75e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 151
            };
        }
    }
}
