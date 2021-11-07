using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HandyWithYourPaws : Template
    {
        public static readonly Guid ID = Guid.Parse("d097c0ce-8055-4fe4-9840-9a34e6fdc3f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Handy With Your Paws",
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
            yield return new TextBlock { Id = Guid.Parse("c964d203-141f-404e-9c5e-d08d268389f8"), Type = TextBlockType.Text, Text = "You gain a +1 circumstance bonus to Crafting checks to (Action: Repair) non-magical items, and you don’t need a repair kit for such repairs as long as you have any amount of junk, spare parts, or debris at your disposal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f94e569c-e68c-4588-bdb7-1dcb8a83057d"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
