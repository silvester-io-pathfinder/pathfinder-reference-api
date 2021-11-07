using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IMeantToDoThat : Template
    {
        public static readonly Guid ID = Guid.Parse("93887a21-b2f1-4f44-ac0c-a5dc664634e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "I Meant to Do That",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e32329ce-efeb-4a7c-b82c-7bfa0bbcc4f6"), Type = TextBlockType.Text, Text = "Somehow your stray bullet causes an unintended reaction that creates a problem for your enemy: perhaps a ricochet knocks your foe’s weapon away or they stumble over stray debris in an attempt to dodge your bullets. Roll a Deception check to attempt to (action: Shove), (action: Trip), or (action: Disarm) the foe you missed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bf2072f7-935a-4f05-83fe-85c69e0ad579"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("a0b93dc2-7b25-4027-bcf4-6e68d7bd2877"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec4dad61-c381-4f24-9620-79d89ce5fe05"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
