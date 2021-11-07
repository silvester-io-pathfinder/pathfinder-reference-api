using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlazeOfRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("50fd48e8-2807-4d2c-b8ee-b85f3d67deb7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blaze of Revelation",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4390d203-7442-49ce-97da-c3e3775007b3"), Type = TextBlockType.Text, Text = "Your mind and body can, for a short time, withstand the devastation of overdrawing your curse. When you would become overwhelmed by your curse, you can forestall the effects for up to 1 minute. On each of your turns during that time, you can cast one revelation spell granted by your mystery (but not domain spells, spells from (feat: Diverse Mystery), or other revelation spells you gained from other abilities) without spending Focus Points or taking any further negative effects." };
            yield return new TextBlock { Id = Guid.Parse("70ba6bfe-1382-4a01-b1e9-7e53b1dd9617"), Type = TextBlockType.Text, Text = "At the end of the minute, the durations of any revelation spells you cast during that time end, you take the normal effects from being overwhelmed by your curse, and you must attempt a DC 40 Fortitude save." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("88704f71-33a4-430f-a2ee-2e21de60719d"),
                CriticalSuccess = "You aren’t otherwise affected.",
                Success = "You are drained 2 and can’t reduce or remove this condition until your next preparations.",
                Failure = "You are drained 4 and can’t reduce or remove this condition until your next preparations.",
                CriticalFailure = "You die.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c738a536-b79f-47d1-b981-674d7b8a779d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
