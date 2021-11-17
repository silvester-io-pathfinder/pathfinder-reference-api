using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class DualWeaponWarrior : Template
    {
        public static readonly Guid ID = Guid.Parse("f4a1b4a9-aa84-4817-ab08-8661cbbdd272");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Dual-Weapon Warrior",
                DedicationFeatId = Feats.Instances.DualWeaponWarriorDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("914412a4-a8bb-4dec-ad12-42094e663dff"), Type = TextBlockType.Text, Text = "You�re able to effortlessly fight with multiple weapons simultaneously, weaving your weapons together into a storm of quick attacks. To you, continual offense is the best form of defense, and you leave little room for your foes to avoid your whirlwind of weapons." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b404487-b707-43ad-8250-4b019367ac4f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 170
            };
        }
    }
}
