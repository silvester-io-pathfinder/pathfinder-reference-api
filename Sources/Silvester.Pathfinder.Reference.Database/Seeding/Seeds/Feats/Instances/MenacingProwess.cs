using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MenacingProwess : Template
    {
        public static readonly Guid ID = Guid.Parse("95e8f84d-efd6-4406-abcd-74bd8853a967");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Menacing Prowess",
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
            yield return new TextBlock { Id = Guid.Parse("19f5e791-93f9-4c9c-a8d2-b30266c33ba4"), Type = TextBlockType.Text, Text = "Scaring off multiple people at once is your specialty. When you (action: Demoralize), you can target up to 2 creatures within 30 feet of you at once. If you are a master of Intimidation, you can (action: Demoralize) up to 4 creatures at once; if you&#39;re legendary, you can (action: Demoralize) up to 8 creatures at once." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("33ec9feb-0111-4aa9-b714-20c58419276c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31085eac-da2e-4cd7-b8a1-d7a3be3229ab"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
