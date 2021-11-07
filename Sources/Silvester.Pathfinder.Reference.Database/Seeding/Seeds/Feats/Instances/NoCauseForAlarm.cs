using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoCauseForAlarm : Template
    {
        public static readonly Guid ID = Guid.Parse("d3745e71-b7e7-4e46-9e71-159d33e1bb1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No Cause for Alarm",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8638991d-3c92-4c9e-af08-e0951210f45b"), Type = TextBlockType.Text, Text = "You attempt to reduce panic. Attempt a Diplomacy check, comparing it to the Will DC of creatures in a 10-foot emanation around you who are frightened. Each of them is temporarily immune for 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("78cc8f98-b431-4905-bd0f-34ba5c2ec8a9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("3e6288e6-c9e4-4191-925d-7c3e7057a44e"),
                CriticalSuccess = "Reduce the creature’s frightened value by 2.",
                Success = "Reduce the creature’s frightened value by 1.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37f95303-b282-4265-91f8-135a27b3f3c7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
