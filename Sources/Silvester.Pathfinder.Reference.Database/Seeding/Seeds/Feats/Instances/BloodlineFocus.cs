using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodlineFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("b017ce67-7feb-4d2f-a4e2-d8aeec05fc1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloodline Focus",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db43e53c-1578-4976-ab44-36137d005b43"), Type = TextBlockType.Text, Text = "Your focus recovers faster. If you have spent at least 2 Focus Points since the last time you (action: Refocused | Refocus), you recover 2 Focus Points when you (action: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyBloodline(Guid.Parse("ddb13973-be33-4e78-a78b-60f3ca4ce3e3"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bacf3a9-b77a-42f7-942a-812c08f1383c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
