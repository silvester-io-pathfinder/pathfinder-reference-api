using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadLips : Template
    {
        public static readonly Guid ID = Guid.Parse("3311aa5f-2535-4561-8fe3-d2e522f27135");

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
            yield return new TextBlock { Id = Guid.Parse("27c8b86f-9a69-4c27-8a77-ce18be3cd1ed"), Type = TextBlockType.Text, Text = $"You can read lips of others nearby who you can clearly see. When you're at your leisure, you can do this automatically. In encounter mode or when attempting a more difficult feat of lipreading, you're fascinated and flat-footed during each round in which you focus on lip movements, and you must succeed at a Society check (DC determined by the GM) to successfully read someone's lips. In either case, the language read must be one that you know." };
            yield return new TextBlock { Id = Guid.Parse("dcb559bb-3e85-4b6f-ae52-c9da68dbc0e7"), Type = TextBlockType.Text, Text = $"If you are deaf or hard of hearing and have Read Lips, you recognize the lip movements for the spoken form of your languages. You can also speak the spoken form of your languages clearly enough for others to understand you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("fbf346c2-f122-44db-8c17-af072350b78c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90dff721-c567-4f87-9fbe-cbf48fee08c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
