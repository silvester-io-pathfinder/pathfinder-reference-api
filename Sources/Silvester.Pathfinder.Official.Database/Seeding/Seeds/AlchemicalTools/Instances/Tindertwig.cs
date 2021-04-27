using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools.Instances
{
    public class Tindertwig : AbstractAlchemicalToolTemplate
    {
        public static readonly Guid ID = Guid.Parse("37fff04c-1d07-49d9-ae10-02fb910e782b");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Tindertwig",
                ItemLevel = 1,
                Price = 20,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.Bulkless.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("237853b6-f295-4158-bb31-dc141d046bae"), Type = TextBlockType.Text, Text = "An alchemical substance applied to one end of this tiny wooden stick ignites when struck against a rough surface. Creating a flame with a tindertwig is much faster than creating a flame with flint and steel. You can ignite the tindertwig and touch it to a flammable object as part of the same Interact action. Core Rulebook 554" };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("14701f2b-1426-4501-b27f-c048f157301e"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
