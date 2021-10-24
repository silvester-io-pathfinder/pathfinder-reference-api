using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Pirate : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Pirate",
                DedicationFeatId = Feats.Instances.PirateDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You live a life of freedom, taking by force and intimidation all that you desire. You may be a privateer, raiding and plundering on behalf of a particular nation or another authority, or you may answer to no one but your own capricious whims. Either way, you rely on intimidation, wits, and combat prowess to take what you want from those you deem less deserving." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Pirates have much in common with swashbucklers, and many pirates have the swashbuckler class (page 82) or archetype (page 153). Much like a swashbuckler’s daring deeds, classic pirate maneuvers are often showy feats intended to impress, intimidate, and gain panache. For example, if you have the panache class feature and your Acrobatics check for a Boarding Assault exceeds the very hard DC for your level, you would gain panache." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 185
            };
        }
    }
}
