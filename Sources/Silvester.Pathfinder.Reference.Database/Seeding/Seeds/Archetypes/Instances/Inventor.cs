using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Inventor : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Inventor",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.InventorDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You revel in the creation of clever inventions, deploying your brilliance to defeat your foes. Explosives, gadgets, and innovative technologies? You have ideas for all of them, and you're eager to test your theories." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Inventor is a great fit for intelligent characters looking to branch out and learn new tricks, especially alchemists, who are already good at Crafting and may appreciate unstable options as an alternative to daily alchemical resources. If they meet the Intelligence requirements, clerics of deities who encourage invention and experimentation like Brigh are an amazing fit, both because it makes narrative sense and because such characters can usually Refocus while fixing their innovation after using an unstable ability." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 49
            };
        }
    }
}
