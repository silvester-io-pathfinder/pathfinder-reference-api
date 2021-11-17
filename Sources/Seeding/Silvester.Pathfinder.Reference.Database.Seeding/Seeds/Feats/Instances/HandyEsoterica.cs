using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HandyEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("77657661-017f-4aa2-83a8-6fabf6957b78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Handy Esoterica",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b311d0e-e57d-4e72-bff2-17fd4bf1634e"), Type = TextBlockType.Text, Text = "You include just about anything you might need amid all your esoterica. You gain the (feat: Prescient Planner) and (feat: Prescient Consumable) feats. When using (feat: Prescient Planner), you can pull out the item as a 2-action activity to remove your backpack (or a similar container) and draw the item, rather than taking 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("608a2e88-e8fa-406f-9808-1cb05dcba612"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
