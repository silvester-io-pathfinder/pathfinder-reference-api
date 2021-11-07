using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntuitiveCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("c85e2f6a-b198-4a59-ad95-ef508c8baa32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intuitive Crafting",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93aebf85-b120-43a1-9579-fd6b6a542d63"), Type = TextBlockType.Text, Text = "Your affinity with process and order makes you a natural artisan. You gain the trained proficiency rank in Crafting (or another skill of your choice, if you’re already trained in Crafting). You gain the (feat: Specialty Crafting) skill feat in a specialty of your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a01fe96-5cae-40d0-97fc-a8873b4d4eec"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
