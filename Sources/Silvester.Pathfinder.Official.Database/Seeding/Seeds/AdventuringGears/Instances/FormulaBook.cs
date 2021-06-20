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
    public class FormulaBook : Template
    {
        public static readonly Guid ID = Guid.Parse("c2ab81a5-73f9-473d-ac8e-7d8f7008d7be");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Formula Book",
                Hands = "1",
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0c14c2f1-0917-475e-94bd-362b01cc6b05"), Type = TextBlockType.Text, Text = "A formula book holds the formulas necessary to make items other than the common equipment from this chapter; alchemists typically get one for free. Each formula book can hold the formulas for up to 100 different items. Formulas can also appear on parchment sheets, tablets, and almost any other medium; there's no need for you to copy them into a specific book as long as you can keep them on hand to reference them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec8a4a5d-8854-480c-8a9b-9fc3aa34e318"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
