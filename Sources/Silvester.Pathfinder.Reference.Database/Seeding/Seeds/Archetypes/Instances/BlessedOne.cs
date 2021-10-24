using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class BlessedOne : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Blessed One",
                DedicationFeatId = Feats.Instances.BlessedOneDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Through luck or deed, heritage or heroics, you carry the blessing of a deity. This blessing manifests as the ability to heal wounds and remove harmful conditions, and exists independent of worship. You might offer thanks daily to the deity whose power you wield, or you might carry these blessings reluctantly, seeking to avoid responsibility or even acting to defy the deity’s influence on you. You might wear the robes of the deity’s order, or you might give little thought and even less reverence to the source of your powers. However you feel about these gifts, there can be no doubt that you wield a special power. Good-aligned deities are most likely to empower a blessed one. However, deities of any alignment can grant such a blessing, as long as they are capable of granting a positive divine font to their clerics. This means such deities as Lamashtu might grant a foul version of the blessed one’s powers." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 162
            };
        }
    }
}
