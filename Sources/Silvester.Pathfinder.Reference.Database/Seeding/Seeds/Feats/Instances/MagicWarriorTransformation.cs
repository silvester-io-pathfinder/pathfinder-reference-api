using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicWarriorTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("64d0fc49-5f3b-4a1c-908f-30cab17cfb0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Warrior Transformation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad27c99f-00f9-428a-a262-eafca8081239"), Type = TextBlockType.Text, Text = "You can transform fully into the animal your mask represents. You gain the (spell: magic warrior transformation) focus spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e7a1722c-1e79-4c0b-b7f9-6ff023b900f9"), Feats.Instances.MagicWarriorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55a81a34-1629-4f7b-b5b0-a73cb1d07e1a"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
