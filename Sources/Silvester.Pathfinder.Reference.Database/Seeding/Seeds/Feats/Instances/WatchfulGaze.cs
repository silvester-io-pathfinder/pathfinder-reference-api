using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WatchfulGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("3675041c-4b37-497e-9e78-bc577fa5cf2b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Watchful Gaze",
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
            yield return new TextBlock { Id = Guid.Parse("26d2ebdb-2d65-4a10-87e0-e96eea693432"), Type = TextBlockType.Text, Text = "You use your many eyes to look in all directions at once, making you extremely observant for a short period of time. You gain all-around vision until the start of your next turn. This lets you see in all directions and prevents you from being flanked." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1097915-ab33-4ebd-b021-30d73e4a2ecb"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
