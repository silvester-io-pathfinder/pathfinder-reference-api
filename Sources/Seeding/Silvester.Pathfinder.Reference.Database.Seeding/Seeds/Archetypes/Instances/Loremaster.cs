using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Loremaster : Template
    {
        public static readonly Guid ID = Guid.Parse("aa69a06c-bed1-47f6-9b75-b8b6bc01f205");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Loremaster",
                DedicationFeatId = Feats.Instances.LoremasterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("43d85488-ef9f-40fc-8283-18c6bdfa0608"), Type = TextBlockType.Text, Text = "Knowledge is power, and you labor in pursuit of that power. No matter the situation, you can usually procure some tidbit of knowledge to inform your actions. You specialize in secrets, both uncovering them and hiding them away, and your command of the written word borders on the supernatural. As you discover deeper secrets of lore, you might develop a power over knowledge that becomes outright magical, allowing you to understand and disguise information even more effectively." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("024afe6d-0a18-4abf-8579-fe59f7c51314"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 179
            };
        }
    }
}
