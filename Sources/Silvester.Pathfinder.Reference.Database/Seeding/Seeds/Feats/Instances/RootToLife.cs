using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RootToLife : Template
    {
        public static readonly Guid ID = Guid.Parse("dcfb1f72-e029-4949-bd29-0bcdaec71740");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Root to Life",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a9d91d5b-d801-4e1c-8722-136dc2e384f2"), Type = TextBlockType.Text, Text = "Marigold, spider lily, pennyroyal—many primal traditions connect flowers and plants with the boundary between life and death, and you can leverage this connection to keep an ally on this side of the line. You place a small plant or similar symbol on an adjacent dying creature, immediately stabilizing them; the creature is no longer dying and is instead unconscious at 0 Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("1d3daef0-8ef8-4566-8c0b-4ed653299cae"), Type = TextBlockType.Text, Text = "If you spend 2 actions instead of 1, you empower the act further by uttering a quick folk blessing to chase away ongoing pain, adding the (trait: auditory) trait to the action. When you do so, attempt flat checks to remove each source of persistent damage affecting the target; due to the particularly effective assistance, the DC is 10 instead of the usual 15." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61b2d282-0496-4a26-a9cc-b0d123089755"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
