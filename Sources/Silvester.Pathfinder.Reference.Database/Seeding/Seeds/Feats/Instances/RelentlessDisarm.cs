using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RelentlessDisarm : Template
    {
        public static readonly Guid ID = Guid.Parse("f21fd1c9-4ab6-4e4f-a207-e5e4be9afbaa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Relentless Disarm",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c15ea4c9-063f-4661-a3f5-5d0d68192646"), Type = TextBlockType.Text, Text = "When you succeed, but don’t critically succeed, at a check to (action: Disarm) a creature, your circumstance bonus to further checks to (action: Disarm) that creature is +4 instead of +2. Other creatures gain only the normal bonus." };
            yield return new TextBlock { Id = Guid.Parse("bfdb8d86-8692-47dd-9393-e5dbde384dd1"), Type = TextBlockType.Text, Text = "When you critically succeed at a (action: Disarm) check, you can immediately (action: Demoralize) your target as a reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("521f7c58-acac-4956-b83a-3a42fdd4c03a"), Feats.Instances.ZephyrGuardDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9563091a-a23a-46e6-bb2f-9f17c68a9be3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("504ef7c9-4e22-4f27-a7fa-51a9d30d1999"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
