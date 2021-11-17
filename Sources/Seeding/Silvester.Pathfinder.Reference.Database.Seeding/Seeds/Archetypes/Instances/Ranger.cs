using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Ranger : Template
    {
        public static readonly Guid ID = Guid.Parse("4ae88860-277f-4ce2-ae5f-740e09e33e8d");
        
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
            yield return new TextBlock { Id = Guid.Parse("c73f912a-0f6a-437b-8262-fe77a8489bcb"), Type = TextBlockType.Text, Text = "You have studied hunting, tracking, and wilderness survival, adding a ranger�s tools to your skill set." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("688be535-6a98-4cbd-a5a6-2829eeafa251"), Type = TextBlockType.Text, Text = "The ranger archetype has access to excellent options to improve a character�s monster knowledge and survival skills, but ranger is of particular interest to any character wanting to become a dedicated archer." };
            yield return new TextBlock { Id = Guid.Parse("6e8a5f87-c770-441d-973f-1946930b544e"), Type = TextBlockType.Enumeration, Text = "Alchemist rangers can add snares to their daily free items, benefiting from a strong Crafting modifier, and their Intelligence makes them exceptional with monster knowledge feats. The ranger archetype is also useful to bombers who want to alternate with in bow attacks." };
            yield return new TextBlock { Id = Guid.Parse("9122a28f-64b5-4e85-8a9d-1debe8868cac"), Type = TextBlockType.Enumeration, Text = "Champion rangers are particularly fitting for deities who connect thematically to nature or have a bow as their favored weapon. (Or, in the case of Erastil, both!)" };
            yield return new TextBlock { Id = Guid.Parse("a20f926c-b6bd-44b9-b1c8-62d70b6e7e9b"), Type = TextBlockType.Enumeration, Text = "Fighter rangers are among the most fearsome archers, combining the best archery feats from both classes to create a fighting style unique to each fighter ranger." };
            yield return new TextBlock { Id = Guid.Parse("20aa9cea-95e2-41ff-983d-b6373ce5ec8f"), Type = TextBlockType.Enumeration, Text = "Rogue rangers make excellent snipers or ranged skirmishers, and snares let them be on the other side of traps for a change." };
            yield return new TextBlock { Id = Guid.Parse("8f492077-fee8-40da-8e2f-55b89ca27a07"), Type = TextBlockType.Enumeration, Text = "Spellcaster rangers benefit greatly from ranger�s feat support, backing up their spells with ranged weapon attacks. Druids have the most thematic overlap with rangers among the spellcasters, allowing you to create a true master of the wilderness." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c84677b8-40a8-49c1-80d2-13863aad0d50"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 228
            };
        }
    }
}
