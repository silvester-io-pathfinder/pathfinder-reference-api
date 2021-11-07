using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadLips : Template
    {
        public static readonly Guid ID = Guid.Parse("19597e33-7a76-486d-b3b8-1b0f072ec1bd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read Lips",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ae6dd3d-ec40-45dc-9f75-66703d87d324"), Type = TextBlockType.Text, Text = "You can read lips of others nearby who you can clearly see. When you’re at your leisure, you can do this automatically. In encounter mode or when attempting a more difficult feat of lipreading, you’re fascinated and flat-footed during each round in which you focus on lip movements, and you must succeed at a Society check (DC determined by the GM) to successfully read someone’s lips. In either case, the language read must be one that you know." };
            yield return new TextBlock { Id = Guid.Parse("b2bfb6f6-ab57-4ab7-8067-7a4dbd791815"), Type = TextBlockType.Text, Text = "If you are deaf or hard of hearing and have Read Lips, you recognize the lip movements for the spoken form of your languages. You can also speak the spoken form of your languages clearly enough for others to understand you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("505172bf-03ab-4aeb-8752-7928aaa5c4fb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c057fb2-1f74-4f5a-ad95-43d71287bc08"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
