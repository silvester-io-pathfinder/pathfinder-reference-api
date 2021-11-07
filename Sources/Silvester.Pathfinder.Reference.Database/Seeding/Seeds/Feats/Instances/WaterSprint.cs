using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WaterSprint : Template
    {
        public static readonly Guid ID = Guid.Parse("ae1614bf-777a-40b0-895b-00f90aaf0432");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Water Sprint",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0f351d0-bdb2-47f3-adec-15e504a8d566"), Type = TextBlockType.Text, Text = "Experience and training have taught you that water has just enough surface tension for a master sprinter to traverse the surface. When you (action: Stride) in a straight line, if you move at least half your Speed over ground, you can move any amount of the remaining distance across a level body of water. If you don’t end your (action: Stride) on solid ground, you fall into the water." };
            yield return new TextBlock { Id = Guid.Parse("7ed20a9a-76bd-4339-b5c0-bf7ad6720b33"), Type = TextBlockType.Text, Text = "If you’re legendary in Athletics, as long as you start on solid ground, any part of your (action: Stride) can cross the water’s surface, even if you aren’t moving a straight line, though you still fall into the water if you don’t end your movement on solid ground." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3a0a55f7-0d52-4bf2-b6a6-80ef4f02ed8c"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c2e8328-aeb8-4d55-b422-98dbd9005e79"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
