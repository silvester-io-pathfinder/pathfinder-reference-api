using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Innocuous : Template
    {
        public static readonly Guid ID = Guid.Parse("49795eed-408b-47fe-86a8-cae444f62af6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Innocuous",
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
            yield return new TextBlock { Id = Guid.Parse("6efffcde-7534-42a0-980a-9dbfb6fc630b"), Type = TextBlockType.Text, Text = "Halflings have been unobtrusive assistants of larger folk for untold ages, and your people count on this assumption of innocence. You gain the trained proficiency rank in Deception (or another skill of your choice, if you’re already trained in Deception). If you fail a Deception check to (Action: Create a Diversion), humanoid creatures aren’t aware that you were trying to trick them unless you get a critical failure on your roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b9d76df-591a-44f1-98f5-9c76c746855a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
