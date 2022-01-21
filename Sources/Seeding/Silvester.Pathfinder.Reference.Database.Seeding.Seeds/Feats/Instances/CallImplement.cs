using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CallImplement : Template
    {
        public static readonly Guid ID = Guid.Parse("57ea1d93-46f6-4526-8ff2-cfa90a31520b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call Implement",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2bc2d07d-502b-41a2-a90e-ad748162e15d"), Type = TextBlockType.Text, Text = $"You can tug on the connections between yourself and your implement, causing it to find its way back to you. You look down at your hand and find your implement has mysteriously appeared in it, as long as it was within 1 mile and on the same plane of existence. If your implement is attended by another creature, that creature can prevent the implement from teleporting away if it succeeds at a Will save against your class DC. If the creature succeeds, you can't attempt to Call that Implement again; you have to track the creature down to get the implement back." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d83ba023-72e8-4bb7-8b01-e307af6ba1b9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
