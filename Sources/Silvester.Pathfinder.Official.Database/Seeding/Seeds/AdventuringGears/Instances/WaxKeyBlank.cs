using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class WaxKeyBlank : AbstractAdventuringGearTemplate
    {
        public static readonly Guid ID = Guid.Parse("0b6cd783-f3bb-43b9-9d2d-fce9d8fa50f6");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Wax Key Blank",
                Hands = "2",
                ItemLevel = "0",
                Price = 100,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("37835ad8-2962-40ab-a1c1-20e5199754ae"), Type = TextBlockType.Text, Text = "This small wooden or metal box is slightly larger than a typical large key and folds open along a hinge, revealing two halves filled with wax. When a key is placed within and the box closed, the wax is displaced by the key, leaving an accurate impression of its shape. Once the key is removed, the impression left behind will remain indefinitely and can later be used to cast a duplicate key. Inserting, impressing, or removing a key each requires an Interact action. The wax inside this blank can be reused, though it must be smoothed over between uses, erasing any previous impression." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("663df493-8f23-493a-a8c4-bbf139fe2de3"),
                SourceId = PathfinderSocietyGuide.ID,
                Page = 115
            };
        }
    }
}
