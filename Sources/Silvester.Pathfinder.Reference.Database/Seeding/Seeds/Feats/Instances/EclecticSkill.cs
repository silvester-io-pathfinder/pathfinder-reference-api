using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EclecticSkill : Template
    {
        public static readonly Guid ID = Guid.Parse("b241622a-23af-4af7-b837-e4fb074a4e2c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Skill",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e11d6d2d-bbf3-4038-ba07-e1760cf85c0c"), Type = TextBlockType.Text, Text = "Your broad experiences translate to a range of skills. Your proficiency bonus to untrained skill checks is equal to your level. You can attempt any skill check that normally requires you to be trained, even if you are untrained. If you have legendary proficiency in Occultism, you can attempt any skill check that normally requires you to have expert proficiency, even if untrained or trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("e022829e-eda4-435a-9108-4d6e96ef9e9c"), Muses.Instances.Polymath.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("5c4478b4-dbd6-4859-a1ed-7a8949381996"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c5faa06-3b10-4cf3-a705-2a3fb7ccb440"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
