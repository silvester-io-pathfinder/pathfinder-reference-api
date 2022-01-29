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
    public class StudentOfTheCanon : Template
    {
        public static readonly Guid ID = Guid.Parse("4f21f529-a91e-47a3-af15-3c8ad8bdee44");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Student of the Canon",
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
            yield return new TextBlock { Id = Guid.Parse("6c5f400d-c461-4543-8b3f-6ffe973fde64"), Type = TextBlockType.Text, Text = $"You've researched many faiths enough to recognize notions about them that are unlikely to be true. If you roll a critical failure at a Religion check to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)} of a religious nature or to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about the tenets of faiths, you get a failure instead. When attempting to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about the tenets of your own faith, if you roll a failure, you get a success instead, and if you roll a success, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6d18e9d1-84d0-4702-8c13-e3f91ad2f7bb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
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
                Id = Guid.Parse("946b6f13-8348-464a-a2f8-996dc74772a9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
