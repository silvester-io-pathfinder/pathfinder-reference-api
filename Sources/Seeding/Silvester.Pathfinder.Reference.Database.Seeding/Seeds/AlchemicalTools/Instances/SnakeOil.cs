using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalTools.Instances
{
    public class SnakeOil : Template
    {
        public static readonly Guid ID = Guid.Parse("fe623283-bc94-42a6-9a63-05fe74c06ab5");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Snake Oil",
                ItemLevel = 1,
                Price = 200,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Consumable.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94cfd7f2-a8a2-44b5-9fbb-3f1893ebd964"), Type = TextBlockType.Text, Text = "You can apply snake oil onto a wound or other outward symptom of an affliction or condition (such as sores from a disease or discoloration from a poison). For the next hour, the symptom disappears and the wounded or afflicted creature doesn’t feel as if it still has the wound or affliction, though all effects remain. A creature can uncover the ruse by succeeding at a DC 17 Perception check, but only if it uses a Seek action to specifically examine the snake oil’s effects." };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("4a59ca8c-7b59-4cb7-bfe3-3afdfc151793"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
