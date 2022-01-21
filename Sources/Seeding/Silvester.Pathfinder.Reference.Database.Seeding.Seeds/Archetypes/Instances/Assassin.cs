using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Assassin : Template
    {
        public static readonly Guid ID = Guid.Parse("ff1f911b-cac4-4ea4-b4d7-0880c5b41193");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Assassin",
                DedicationFeatId = Feats.Instances.AssassinDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9e62661e-7d80-4227-8b86-e4bc632882e1"), Type = TextBlockType.Text, Text = "Targeted killing through stealth and subterfuge is the expertise of an assassin. While assassins are skilled in ending lives and many are evil, some live by a moral code, preying on the wicked, the cruel, or those who revel in unchecked aggression or power." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00cd8481-c12a-479b-b941-128203bc6db1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 158
            };
        }
    }
}
