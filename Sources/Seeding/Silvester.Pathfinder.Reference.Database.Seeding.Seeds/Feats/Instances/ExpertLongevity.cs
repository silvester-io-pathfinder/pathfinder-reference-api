using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertLongevity : Template
    {
        public static readonly Guid ID = Guid.Parse("e8fc85ba-9385-442f-9e62-0b9bd1cd43c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Longevity",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e662240c-5916-4536-aa79-b28b9f02eac1"), Type = TextBlockType.Text, Text = $"You've continued to refine the knowledge and skills you've gained through your life. When you choose a skill in which to become trained with {ToMarkdownLink<Models.Entities.Feat>("Ancestral Longevity", Feats.Instances.AncestralLongevity.ID)}, you can also choose a skill in which you are already trained and become an expert in that skill. This lasts until your {ToMarkdownLink<Models.Entities.Feat>("Ancestral Longevity", Feats.Instances.AncestralLongevity.ID)} expires." };
            yield return new TextBlock { Id = Guid.Parse("a3ee99ed-beed-4de2-9f4c-58a1700e9441"), Type = TextBlockType.Text, Text = $"When the effects of {ToMarkdownLink<Models.Entities.Feat>("Ancestral Longevity", Feats.Instances.AncestralLongevity.ID)} and Expert Longevity expire, you can retrain one of your skill increases. The skill increase you gain from this retraining must either make you trained in the skill you chose with {ToMarkdownLink<Models.Entities.Feat>("Ancestral Longevity", Feats.Instances.AncestralLongevity.ID)} or make you an expert in the skill you chose with Expert Longevity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a5f36b09-bf06-457d-a793-6051eb99112d"), Feats.Instances.AncestralLongevity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("444ffc1f-da7d-4db8-91f9-63c0ab84892d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
