using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Multilingual : Template
    {
        public static readonly Guid ID = Guid.Parse("19a00eaf-85d8-4d26-9343-cb3da835171b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multilingual",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, you learn additional languages.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4850a9d-3ce4-44b9-8145-38aae59eac29"), Type = TextBlockType.Text, Text = "You easily pick up new languages. You learn two new languages, chosen from common languages, uncommon languages, and any others you have access to. You learn an additional language if you are or become a master in Society and again if you are or become legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c61e155a-c90e-4e1c-b475-71da6740305b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24708121-89f5-4340-8652-08b10a204c6d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
