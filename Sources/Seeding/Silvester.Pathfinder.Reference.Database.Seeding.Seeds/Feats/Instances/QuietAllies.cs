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
    public class QuietAllies : Template
    {
        public static readonly Guid ID = Guid.Parse("1f0564f4-5cc3-4676-b07a-62db64b9dc1b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quiet Allies",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9536542d-6e19-4538-8b03-d75204a0e9c1"), Type = TextBlockType.Text, Text = $"You're skilled at moving with a group. When you are {ToMarkdownLink<Models.Entities.Activity>("Avoiding Notice", Activities.Instances.AvoidNotice.ID)} and your allies {ToMarkdownLink<Models.Entities.Activity>("Follow the Expert", Activities.Instances.FollowTheExpert.ID)}, you and those allies can roll a single Stealth check, using the lowest modifier, instead of rolling separately. This doesn't apply for initiative rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a97767d1-d2d8-4619-8d3e-e8cd4f202295"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
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
                Id = Guid.Parse("dbefe8a1-24f2-4554-a57d-737cfe4d7d9b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
