using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools.Instances
{
    public class Sunrod : Template
    {
        public static readonly Guid ID = Guid.Parse("cad37b1b-7d1e-4a1a-acb4-23a9814683ab");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Sunrod",
                ItemLevel = 1,
                Price = 300,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8238f38f-f33e-4252-9f51-f0ec7ae0b938"), Type = TextBlockType.Text, Text = "This 1-foot-long, gold-tipped rod glows after it’s struck on a hard surface. For the next 6 hours, it sheds bright light in a 20-foot radius (and dim light to the next 40 feet)." };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("64fa1397-8f70-4a14-9cfa-8f078fc31383"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
