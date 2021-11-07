using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeneathNotice : Template
    {
        public static readonly Guid ID = Guid.Parse("fd668ce7-6300-4128-97b0-e281aa9c0ef9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beneath Notice",
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
            yield return new TextBlock { Id = Guid.Parse("203768f8-51ce-49c9-9600-ee0924d31e27"), Type = TextBlockType.Text, Text = "You are skilled at hiding from your foes and targets among the common populace. You gain the (feat: Quick Disguise) and (feat: Slippery Secrets) skill feats. In addition, while in a crowd, you can (action: Impersonate) a nondescript member of the crowd as a three action activity (one action if you are legendary in Deception)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("29630dcb-4823-493c-bdb7-8b1c8194067c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a068a22d-5b2f-4c32-9b9f-8dc002a5e852"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
