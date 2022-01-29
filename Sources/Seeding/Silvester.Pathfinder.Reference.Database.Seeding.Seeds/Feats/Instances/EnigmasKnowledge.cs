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
    public class EnigmasKnowledge : Template
    {
        public static readonly Guid ID = Guid.Parse("393f822b-beea-47e6-a6ab-5ec39423786b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enigma's Knowledge",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79aa4ca5-9642-496f-a7ab-6b4cfb2b705f"), Type = TextBlockType.Text, Text = $"Your muse whispers knowledge to you at all the right times. You gain the benefits of the {ToMarkdownLink<Models.Entities.Feat>("Automatic Knowledge", Feats.Instances.AutomaticKnowledge.ID)} skill feat with any skill you can use to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}. As per the special clause in the {ToMarkdownLink<Models.Entities.Feat>("Automatic Knowledge", Feats.Instances.AutomaticKnowledge.ID)} feat, you can still only use {ToMarkdownLink<Models.Entities.Feat>("Automatic Knowledge", Feats.Instances.AutomaticKnowledge.ID)} once per round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c1899a67-6bde-4ae3-a813-0465d39c8ac4"), Feats.Instances.AssuredKnowledge.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6526ca5c-5b9f-48e4-a725-de16de5eeb5d"), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("76f47a55-490c-407b-b51e-f33585ceb7b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
