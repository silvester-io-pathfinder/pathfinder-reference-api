using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Ritualist : Template
    {
        public static readonly Guid ID = Guid.Parse("5a94dcfe-4642-41dd-8bda-c0ffc52f662a");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Ritualist",
                DedicationFeatId = Feats.Instances.RitualistDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5dfbc1bc-02ad-4e06-846f-5dd3c3e4f960"), Type = TextBlockType.Text, Text = "While some learn the art of ritual casting through rigorous study, other gifted individuals may find that a combination of natural talent and luck gives them surprising skill at performing rituals, whether they want that power or not." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4eba8f42-63d1-432b-a1b2-71593cc3692c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 187
            };
        }
    }
}
