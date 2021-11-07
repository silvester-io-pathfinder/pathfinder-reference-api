using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MeditativeWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("e82b5403-0621-421f-97a2-982b572e50cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Meditative Wellspring",
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
            yield return new TextBlock { Id = Guid.Parse("b07d8ca0-b28e-4f61-ad5b-78168b761010"), Type = TextBlockType.Text, Text = "When you clear your mind, your focus comes flowing back in a powerful rush. If you have spent at least 3 Focus Points since the last time you (action: Refocused | Refocus), you recover 3 Focus Points when you (action: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d3210969-bae0-4ef6-b15a-1eb8a25ab002"), Feats.Instances.MeditativeFocus.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82dc4a97-fda4-447e-b1c9-e3e3b6a94fe8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
