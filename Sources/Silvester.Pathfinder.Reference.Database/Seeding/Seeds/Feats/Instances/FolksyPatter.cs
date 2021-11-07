using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FolksyPatter : Template
    {
        public static readonly Guid ID = Guid.Parse("b12299d4-6b91-49b6-8a87-6ebc1f238431");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Folksy Patter",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1798be61-9d68-4cbf-8cc4-fbf8d1fe2b6e"), Type = TextBlockType.Text, Text = "You are adept at disguising coded messages as folksy idioms. Using slang, jokes, halfling loanwords, and the like, you convey a simple message consisting of three basic words (such as “Danger assassin flee” or “Meet me moonrise”). Your intended listener can attempt a Perception check to discern the message (DC 20 if an ally, DC 15 if a halfling ally, DC 10 if a halfling ally with Folksy Patter). Eavesdroppers can also attempt a Perception check against your Deception DC to discern your meaning. Any bonuses or penalties to Perception checks to (action: Sense Motive) apply." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc9c8b4f-8253-4869-a350-41fdc6d3c51b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
