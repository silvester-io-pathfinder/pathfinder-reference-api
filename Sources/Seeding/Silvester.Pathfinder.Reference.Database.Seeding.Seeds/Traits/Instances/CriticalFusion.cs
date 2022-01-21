using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class CriticalFusion : Template
    {
        public static readonly Guid ID = Guid.Parse("94f67c58-b715-4791-8b94-819c44537a9a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Critical Fusion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0fc4703-1e28-485f-a358-f52d475d8e12"), Type = TextBlockType.Text, Text = "Critical fusion is a new trait for combination weapons that grants you two additional options for the critical specialization effect when using the combination weapon's melee version to make a melee attack while the firearm is loaded. If you choose to use one of them, they replace the melee usage's normal critical specialization effect." };
            yield return new TextBlock { Id = Guid.Parse("6860f5d8-809f-4fef-849a-7018bc7c61e7"), Type = TextBlockType.Text, Text = "First, you can discharge the firearm to create a loud bang and concussion, using the critical specialization effect for firearms instead of the melee weapon group's critical specialization effect. Second, you can choose to discharge the firearm to increase the critical hit's momentum or shoot the foe as you attack them in melee, dealing 2 additional damage per weapon damage die. Both of these options discharge the firearm, which typically means you have to reload it before firing it again." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26703333-9047-4298-9ebe-799cc01aec12"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 231
            };
        }
    }
}
