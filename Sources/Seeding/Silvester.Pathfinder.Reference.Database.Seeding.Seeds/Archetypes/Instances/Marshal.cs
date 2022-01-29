using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Marshal : Template
    {
        public static readonly Guid ID = Guid.Parse("765b798c-929f-4282-8a7d-a64d4f1a081a");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Marshal",
                DedicationFeatId = Feats.Instances.MarshalDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("407e1073-d1b9-4456-a957-e2c08490c0ec"), Type = TextBlockType.Text, Text = "Marshals are leaders, first and foremost. Marshals can come from any class or background, though they all share a willingness to sacrifice their own glory for the greater good of the team. Some marshals lead from the front, sword and shield raised, while others may call instructions and encouragements from the rear while providing allied spellcasters with skilled support. Regardless of their preferred method of combat, marshals' ability to bring the best out in every ally is a valuable addition to any group." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da738787-2902-4077-b250-cfe206645650"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 180
            };
        }
    }
}
