using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeneathNotice : Template
    {
        public static readonly Guid ID = Guid.Parse("2d5b1b42-027f-499b-a5c9-7d037276ed9b");

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
            yield return new TextBlock { Id = Guid.Parse("f6efc794-565d-404c-9adb-9011af2ff293"), Type = TextBlockType.Text, Text = $"You are skilled at hiding from your foes and targets among the common populace. You gain the {ToMarkdownLink<Models.Entities.Feat>("Quick Disguise", Feats.Instances.QuickDisguise.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Slippery Secrets", Feats.Instances.SlipperySecrets.ID)} skill feats. In addition, while in a crowd, you can {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} a nondescript member of the crowd as a three action activity (one action if you are legendary in Deception)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d1cb12e5-1c26-4ea5-9e07-6da81f676678"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db1c3369-1529-47fa-8e9a-761cd737dd7e"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
