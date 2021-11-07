using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlastLock : Template
    {
        public static readonly Guid ID = Guid.Parse("3658135a-9817-4c58-85b1-34a28157ff64");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blast Lock",
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
            yield return new TextBlock { Id = Guid.Parse("a240e09a-342e-4a43-a0ad-1fc7c079504f"), Type = TextBlockType.Text, Text = "Sometimes taking the shortest distance between two points involves removing an obstacle or two. You shoot your firearm at a lock within 10 feet. Make an attack roll against the DC required to (action: Pick the Lock|Pick a Lock)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("85e7cb81-9aa0-4e0d-b345-9d329a658194"),
                CriticalSuccess = "You open the lock, or you achieve two successes toward opening a complex lock.",
                Success = "You open the lock, or you achieve one success toward opening a complex lock.",
                Failure = "You fail to open the lock, and your shot makes it harder to open. Future attempts to (action: Pick the Lock|Pick a Lock) or Blast the Lock take a –2 circumstance penalty.",
                CriticalFailure = "You fail to open the lock, and your shot makes it much harder to open. Future attempts to (action: Pick the Lock|Pick a Lock) or Blast the Lock take a –4 circumstance penalty.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07d58a8e-794a-46ed-a21d-37d961514b05"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
