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
    public class ThoroughReports : Template
    {
        public static readonly Guid ID = Guid.Parse("b34b360e-b5ea-4b66-ab4c-70cd05b1d96b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thorough Reports",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76bdce14-5eae-4c38-9eed-6a65b39c6c98"), Type = TextBlockType.Text, Text = $"Your reports are thorough and informative, and putting your thoughts to paper helps you retain the information. Keep track of each type of creature you successfully identify with {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}. When attempting {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} checks against creatures on your list in later encounters, you gain a +2 circumstance bonus, and you learn an additional fact about such creatures on a success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2614dafa-74a6-47cf-a7e0-7163c4fd2808"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71985884-feff-43e4-8758-899395996f5a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
