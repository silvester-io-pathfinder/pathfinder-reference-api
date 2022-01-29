using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class DragonDisciple : Template
    {
        public static readonly Guid ID = Guid.Parse("c5dfd2df-b061-4610-8dc0-969c44b395b2");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Dragon Disciple",
                DedicationFeatId = Feats.Instances.DragonDiscipleDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7f3f92b7-e497-4d88-92c3-4941885749f2"), Type = TextBlockType.Text, Text = "The rippling waves of fear, the rustling of thick scales, and the beat of immense wings signal the arrival of a great dragon. The awe-inspiring presence of these creatures makes them worthy of reverence - or even outright worship. Dragon disciples dedicate themselves to becoming like these great beasts, with each disciple striving to typify one variety of dragon. Sorcerers of draconic blood, barbarians with the dragon instinct, and many kobolds with close ties to their draconic predecessors become dragon disciples, but anyone who has encountered one of these terrifying creatures might follow this path." };
            yield return new TextBlock { Id = Guid.Parse("9184b045-87f6-4e91-947a-4eb74553bf02"), Type = TextBlockType.Text, Text = "As a dragon disciple, you study and learn from the example of dragons, but that doesn't necessarily mean that you admire the dragons you emulate. While most dragon disciples do indeed revere their chosen dragon, countless tales are told of dragon disciples born of great personal tragedy at the hands of boundless draconic fury. These disciples have transformed themselves into what they despise in order to gain the power to destroy their draconic tormentor and at long last earn their revenge." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56f8a2fe-4b00-4259-806d-d5bf08073da6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 168
            };
        }
    }
}
