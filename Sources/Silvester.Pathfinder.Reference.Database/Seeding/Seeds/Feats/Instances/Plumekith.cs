using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Plumekith : Template
    {
        public static readonly Guid ID = Guid.Parse("a81a5fe8-17ae-4414-90dc-ec0ba56a412f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plumekith",
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
            yield return new TextBlock { Id = Guid.Parse("67f76f96-0eb0-4265-b9e1-301e8748b4ec"), Type = TextBlockType.Text, Text = "Your blood soars with the power of the magnificent garuda, proud and stoic avian warriors. You only take half the normal damage from falling and gain a +2 circumstance bonus to saving throws against effects with the (trait: air) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6369b39f-f949-4faf-8447-0f5838385486"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
