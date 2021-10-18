using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses.Instances
{
    public class StaffNexus : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ArcaneThesis GetArcaneThesis()
        {
            return new ArcaneThesis
            {
                Id = ID, 
                Name = "Staff Nexus", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your thesis maintains that early and intense adoption of staves from the first days of study can create a symbiotic bond between spellcaster and staff, allowing them to create remarkable magic together. You've formed such a connection with a makeshift staff you built, and you are ready to infuse any staff you encounter with greater power." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You begin play with a makeshift staff of your own invention. It contains one cantrip and one 1st-level spell, both from your spellbook, but it gains no charges normally during your preparations; you must expend a spell slot to grant it charges in the same way you would add additional charges to a normal staff. You can Craft your makeshift staff into any other type of staff for the new staff's usual cost, adding the two spells you originally chose to the staff you Craft." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 8th level, you can expend two spells instead of one when preparing your staff, adding additional charges equal to the combined levels of the expended spells. At 16th level, you can expend up to a total of three spells to add charges to the staff, adding additional charges equal to the combined levels of all three spells." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 142
            };
        }
    }
}
