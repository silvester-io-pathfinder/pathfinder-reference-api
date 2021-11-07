using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManifoldEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("7081519a-5774-433d-bbb6-267648cda4fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Manifold Edge",
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
            yield return new TextBlock { Id = Guid.Parse("bb5ec0be-c290-4f50-bace-da2eb8bd9337"), Type = TextBlockType.Text, Text = "You’ve learned every possible edge to use against your foes. When you use (feat: Hunt Prey), you can gain a hunter’s edge benefit other than the one you selected at 1st level. If you do, you don’t gain the additional benefit from masterful hunter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a0cf8a97-6bae-4490-a4f7-2558fdc5adb6"), Feats.Instances.HuntersEdge.ID);
            builder.HaveSpecificFeat(Guid.Parse("c3877100-015a-40e7-93e0-953d587b9492"), Feats.Instances.MastefulHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27dc4dd0-003f-4765-8d74-be5555f4313a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
