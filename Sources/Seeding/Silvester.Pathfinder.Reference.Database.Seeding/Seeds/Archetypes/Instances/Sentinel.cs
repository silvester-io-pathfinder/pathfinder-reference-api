using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Sentinel : Template
    {
        public static readonly Guid ID = Guid.Parse("6b32b008-b36f-49c2-93f6-127d5f66348a");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Sentinel",
                DedicationFeatId = Feats.Instances.SentinelDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d53b6f27-5d18-40ea-a053-36e340ea7a24"), Type = TextBlockType.Text, Text = "Armor offers solid, reassuring protection in combat, and as someone who faces danger on a regular basis, you have made it your business to get the most out of your defenses. You stand solid on any battlefield, encased in the sturdiest armor you can find. When danger threatens, your solid defenses will safely get you, and possibly your companions, home again. As a sentinel, you might be a member of an order of knights or bodyguards that trained you how best to take advantage of heavy armor. On the other hand, you might just be an adventurer who took one too many scrapes and decided that enough was enough, so you trained yourself to wear the heaviest plate you could get your hands on. Some witches or sorcerers have chosen to follow the path of the sentinel to increase their survivability." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a847a0e7-de76-4bac-b48b-e78f125e34fc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 191
            };
        }
    }
}
