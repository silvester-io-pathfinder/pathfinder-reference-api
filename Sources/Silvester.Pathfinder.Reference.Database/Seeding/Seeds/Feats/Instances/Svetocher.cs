using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Svetocher : Template
    {
        public static readonly Guid ID = Guid.Parse("4a62b895-6805-4010-ad9a-fa66c615df58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Svetocher",
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
            yield return new TextBlock { Id = Guid.Parse("cca592c3-4aea-44ae-aaa0-d6512625b870"), Type = TextBlockType.Text, Text = "You were born to one of the moroi, the most common vampires, and you share their supernatural fortitude and power of persuasion. When you have the drained condition, calculate the penalty to your Fortitude saves and your Hit Point reduction as though the condition value were 1 lower. You are trained Diplomacy. If you would automatically be trained in it, you instead become trained in a skill of your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e53c0459-5ed4-41cc-9f22-8406936a87f1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
