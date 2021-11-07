using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalShot : Template
    {
        public static readonly Guid ID = Guid.Parse("7fda3604-eaad-44fe-89e6-4b23a777545e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Shot",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("314d7533-608d-4e71-b626-584c7bd4a1a9"), Type = TextBlockType.Text, Text = "You’ve practiced a technique for mixing alchemical bombs with your loaded shot. You (action: Interact) to retrieve the bomb (if it’s not already in your hand) and pour its contents onto your ammunition, consuming the bomb. Next, (action: Strike) with your firearm. The (action: Strike) deals damage of the same type as the bomb (for instance, fire damage for alchemist’s fire), and it deals an additional 1d6 persistent damage of the same type as the bomb. If the (action: Strike) is a failure, you take 1d6 damage of the same type as the bomb you used, and the firearm (trait: misfires|misfire)." };
            yield return new TextBlock { Id = Guid.Parse("fb3a3eb3-7512-40af-be99-aa5907277220"), Type = TextBlockType.Text, Text = "The persistent damage increases to 2d6 if the bomb is 11th level or higher, or 3d6 if it’s 17th level or higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("449020d3-e49d-472e-9c12-2602b9d35113"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
