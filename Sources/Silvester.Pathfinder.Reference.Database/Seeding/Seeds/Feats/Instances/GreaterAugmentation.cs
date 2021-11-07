using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterAugmentation : Template
    {
        public static readonly Guid ID = Guid.Parse("fd02f630-8f09-4c8d-9ce8-a75b110b95fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Augmentation",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3585cf75-1e4c-4ea2-977f-6c16ef80258a"), Type = TextBlockType.Text, Text = "You’ve greatly improved your abilities and your core can support further augmentations. You gain the enhancement benefits of one of your 1st-, 5th-, 9th-, or 13th-level automaton ancestry feats." };
            yield return new TextBlock { Id = Guid.Parse("86b69a10-b45f-400b-84cb-a8f0b2e36ed5"), Type = TextBlockType.Text, Text = "You are also capable of reconfiguring your augmentations to meet your needs. You can spend one week of downtime to change the enhancement you gain with this feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("becca1fd-f0dc-4903-a1e6-2152ffd6aa64"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
