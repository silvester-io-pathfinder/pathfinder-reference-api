using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashImmediateGratification : Template
    {
        public static readonly Guid ID = Guid.Parse("60f89cf9-6270-4fcc-b343-0b1caa91332a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Immediate Gratification",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1572c259-0653-440a-b27a-4e34834a9cd9"), Type = TextBlockType.Text, Text = "You can push your mind immediately into an overloaded state, though doing so accelerates your mental strain." };
            yield return new TextBlock { Id = Guid.Parse("b2cf5263-b960-4100-bf8e-7cf52afc4fc3"), Type = TextBlockType.Text, Text = "~ Benefit: You gain the basic benefits of having your psyche unleashed, allowing you to amp focus spells without paying the cost, but you gain no specific benefits beyond that." };
            yield return new TextBlock { Id = Guid.Parse("7c90ea40-1a06-4222-8846-a775bd17c94b"), Type = TextBlockType.Text, Text = "~ Drawback: Prematurely pushing yourself into an overloaded state leaves your mind struggling to catch up. You’re stupefied 1 for the duration of your Unleashed psyche, and you can’t remove or mitigate this condition in any way." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37072b99-3985-4932-b40a-054d9af1975e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
