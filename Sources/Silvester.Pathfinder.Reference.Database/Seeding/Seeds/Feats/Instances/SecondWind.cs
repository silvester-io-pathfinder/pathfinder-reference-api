using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecondWind : Template
    {
        public static readonly Guid ID = Guid.Parse("ea942e3c-a55d-4c6a-8f48-b01b33b69beb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Second Wind",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e95374ed-5c28-49d6-afe2-8a57126ed362"), Type = TextBlockType.Text, Text = "You can enter a second rage, but afterward you need to catch your breath. You can (Action: Rage) without waiting for 1 minute after the previous (Action: Rage) (or 1 round, if you have the quick rage class feature), but when you end this second (Action: Rage), you’re fatigued until you rest for 10 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac221502-bfe8-4823-9c95-35a8fe2d9038"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
