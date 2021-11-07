using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterBloodline : Template
    {
        public static readonly Guid ID = Guid.Parse("474f6f79-111a-4101-99d1-86fea0c8c45f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Bloodline",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("828cea89-9057-4f0c-af65-a9d0bd83968f"), Type = TextBlockType.Text, Text = "Further communion with the legacy of your bloodline has uncovered greater secrets. You gain the greater bloodline spell associated with your bloodline. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyBloodline(Guid.Parse("16abd3f0-fd1e-4e71-948a-e7bc3577266f"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5feb3f21-daf7-4251-9ffb-627314c56f8e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
