using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Snarecrafter : Template
    {
        public static readonly Guid ID = Guid.Parse("31216e96-14ef-4c3f-8194-e00944397e39");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Snarecrafter",
                DedicationFeatId = Feats.Instances.SnarecrafterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7810f844-6179-4dfc-ae86-7f10257a7d51"), Type = TextBlockType.Text, Text = "You�re able to take ordinary materials and use them to create deadly snares, special traps that you can rig up quickly when the situation demands. While traps might grant you less brute force to apply in a fair fight than weapons would, you rarely allow your fights to be fair. Instead, when a battle takes place at a location of your choice, you have a major advantage thanks to your well-placed snares. Once your foes come to realize that you may have trapped any location on the battlefield, their fear of walking into another trap can help you corral them toward the waiting blades of your allies, or even make them too paranoid to move at all, locking them in place." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("481b6590-75e9-4224-8e48-97d2855a0ba7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 194
            };
        }
    }
}