using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoblinSong : Template
    {
        public static readonly Guid ID = Guid.Parse("63526701-3265-4907-b56f-29afff41c4dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Goblin Song",
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
            yield return new TextBlock { Id = Guid.Parse("dd8e2620-9bed-42c5-b4fd-67349d1f5f4f"), Type = TextBlockType.Text, Text = "You sing annoying goblin songs, distracting your foes with silly and repetitive lyrics. Attempt a Performance check against the Will DC of a single enemy within 30 feet. This has all the usual traits and restrictions of a Performance check." };
            yield return new TextBlock { Id = Guid.Parse("2907c648-679a-45c6-9c62-1008857f2f1c"), Type = TextBlockType.Text, Text = "You can affect up to two targets within range if you have expert proficiency in Performance, four if you have master proficiency, and eight if you have legendary proficiency." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("025e5910-8c64-40fb-9b07-73bfc523eafc"),
                CriticalSuccess = "The target takes a -1 status penalty to Perception checks and Will saves for 1 minute.",
                Success = "The target takes a -1 status penalty to Perception checks and Will saves for 1 round.",
                
                CriticalFailure = "The target is temporarily immune to attempts to use Goblin Song for 1 hour.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85ba44b9-e50a-44e3-a8e9-255620634655"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
