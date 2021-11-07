using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ControlTower : Template
    {
        public static readonly Guid ID = Guid.Parse("cede0f11-14e7-4a7d-be8f-04eb1efd198d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Control Tower",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a43ca3fa-dec6-4789-9872-17afb1ca0cdd"), Type = TextBlockType.Text, Text = "Your keen senses and ability to process battlefield information have dramatically improved, allowing you to drastically reduce the advantage of unseen foes. You and allies in your overwatch field gain a +2 circumstance bonus when using the (action: Seek) action to find hidden or undetected creatures within the overwatch field. You and your allies don’t have to succeed at a flat check to target a concealed creature within your overwatch field. When you or an ally targets a hidden creature in your overwatch field, reduce the DC of the flat check to 5." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ba1aab95-3b80-49ff-8eae-28250b6cf82b"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("86491af2-ffd0-4052-8faa-daba97bc6b3f"), Proficiencies.Instances.Master.ID, Skills.Instances.Percepton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("604c611b-b4a5-4f8c-a36d-4a602aeecfc9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
