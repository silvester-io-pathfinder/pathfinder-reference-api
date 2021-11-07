using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneShotOneKill : Template
    {
        public static readonly Guid ID = Guid.Parse("2008f05c-caf4-415e-bd87-ec471c6d058a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One Shot, One Kill",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll Stealth for initiative",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3c2ac84-71a0-4f6b-8ce7-ba44eba30eac"), Type = TextBlockType.Text, Text = "Your first shot is the deadliest. Interact to draw a firearm or crossbow. On your first turn, your first (action: Strike) with that weapon deals an additional 1d6 precision damage. This precision damage increases to 2d6 at 9th level and 3d6 at 15th level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce2853c8-a539-440b-8eaa-6e5c14a94f74"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
