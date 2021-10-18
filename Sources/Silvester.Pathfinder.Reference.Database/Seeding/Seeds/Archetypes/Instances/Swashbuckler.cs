using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Swashbuckler : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Swashbuckler",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.SwashbucklerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You fight with flair and style, adding swashbuckling tricks to your combat repertoire." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The swashbuckler archetype is a great fit for martial characters who want to be a bit flashier or for Charisma-based spellcasters who want to add a bit of dramatic flair to their routine. Multiclass swashbucklers work especially well for characters who already wanted to perform the actions associated with gaining panache, such as a monk or barbarian with the gymnast style or a braggart, battledancer, or wit-style bard." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 153
            };
        }
    }
}
