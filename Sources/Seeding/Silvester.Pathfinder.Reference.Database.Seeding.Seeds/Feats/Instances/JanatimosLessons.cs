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
    public class JanatimosLessons : Template
    {
        public static readonly Guid ID = Guid.Parse("549dfa34-d0f8-42cc-984d-03162ce112c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Janatimo's Lessons",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("999d8c4d-76f0-4c31-a876-702b000d3603"), Type = TextBlockType.Text, Text = $"Thanks to Janatimo's secret techniques, you can weave your knowledge and words into powerful tools to assist your allies in life-threatening situations. When you use {ToMarkdownLink<Models.Entities.Feat>("Uzunjati Recollection", Feats.Instances.UzunjatiRecollection.ID)} to tell a story and {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about a creature during a combat encounter, if you succeed at both checks, your story carries deeper meaning. This grants your allies a +1 circumstance bonus to their next attack roll and saving throw against the creature during that encounter, as well as to their AC against that creature's next attack roll during that encounter. If you critically succeed at both checks, the bonuses also apply to all attack rolls, saves, and AC against that creature for 2 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6e55f2bb-f176-419e-bb99-b11ff80b6f3a"), Feats.Instances.UzunjatiRecollection.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88aae35b-378d-4787-97ca-514a3f7ac556"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
