using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HandyEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("296840ad-3afa-4597-a36f-71dd26993ca2");

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
            yield return new TextBlock { Id = Guid.Parse("58bfd53d-acb5-494d-94a3-cb27db3c938b"), Type = TextBlockType.Text, Text = "You include just about anything you might need amid all your esoterica. You gain the (feat: Prescient Planner) and (feat: Prescient Consumable) feats. When using (feat: Prescient Planner), you can pull out the item as a 2-action activity to remove your backpack (or a similar container) and draw the item, rather than taking 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82fa7e06-22a6-4550-84e5-bb8b542c8525"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
