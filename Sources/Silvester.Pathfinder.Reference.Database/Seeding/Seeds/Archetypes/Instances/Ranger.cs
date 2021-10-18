using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Ranger : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Ranger",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.RangerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have studied hunting, tracking, and wilderness survival, adding a ranger’s tools to your skill set." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The ranger archetype has access to excellent options to improve a character’s monster knowledge and survival skills, but ranger is of particular interest to any character wanting to become a dedicated archer." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Alchemist rangers can add snares to their daily free items, benefiting from a strong Crafting modifier, and their Intelligence makes them exceptional with monster knowledge feats. The ranger archetype is also useful to bombers who want to alternate with in bow attacks." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Champion rangers are particularly fitting for deities who connect thematically to nature or have a bow as their favored weapon. (Or, in the case of Erastil, both!)" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Fighter rangers are among the most fearsome archers, combining the best archery feats from both classes to create a fighting style unique to each fighter ranger." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Rogue rangers make excellent snipers or ranged skirmishers, and snares let them be on the other side of traps for a change." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Spellcaster rangers benefit greatly from ranger’s feat support, backing up their spells with ranged weapon attacks. Druids have the most thematic overlap with rangers among the spellcasters, allowing you to create a true master of the wilderness." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 228
            };
        }
    }
}
