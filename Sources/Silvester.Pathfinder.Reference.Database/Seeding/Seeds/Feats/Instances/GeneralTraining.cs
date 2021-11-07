using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GeneralTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("760bcde6-756a-4ce6-a60d-1c57aee8c960");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "General Training",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times, choosing a different feat each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b92ad1ae-2c77-4823-b965-50d2024edd94"), Type = TextBlockType.Text, Text = "Your adaptability manifests in your mastery of a range of useful abilities. You gain a 1st-level general feat. You must meet the feat’s prerequisites, but if you select this feat during character creation, you can select the feat later in the process in order to determine which prerequisites you meet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9f50ed3a-05db-439c-bb78-af04ee0ad3c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
