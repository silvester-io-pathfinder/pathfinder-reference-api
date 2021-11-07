using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SneakSavant : Template
    {
        public static readonly Guid ID = Guid.Parse("2be4949f-e651-4632-a72d-8180f7e57be2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sneak Savant",
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
            yield return new TextBlock { Id = Guid.Parse("2d9b9066-1468-4785-92a6-33f0023a0b58"), Type = TextBlockType.Text, Text = "It is almost impossible to spot you without taking effort to look. When you roll a failure on a (action: Sneak) action, you get a success instead. You can still critically fail." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("41c72ca7-6efe-40d7-92e5-b8051ee7491a"), Proficiencies.Instances.Master.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e4b01f1-d987-4a84-ae5b-2aac9729e8fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
