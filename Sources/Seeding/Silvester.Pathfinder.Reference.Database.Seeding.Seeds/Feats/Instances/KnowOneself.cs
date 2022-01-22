using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnowOneself : Template
    {
        public static readonly Guid ID = Guid.Parse("49bfc481-997e-4cd0-906d-81117bdd9777");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Know Oneself",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll a critical failure on a saving throw against an emotion effect.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1375a582-0a1a-4463-a915-5cbb36158d82"), Type = TextBlockType.Text, Text = $"~ Access: Vudrani ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("de556137-5a41-4bff-bb21-95a5d16fdd5f"), Type = TextBlockType.Text, Text = $"You center yourself and call to mind the Vudrani monastic ideals of mindfulness and self-knowledge. You fail the save against the {ToMarkdownLink<Models.Entities.Trait>("emotion", Traits.Instances.Emotion.ID)} effect instead of critically failing." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d8eefce-3c1b-4e78-b9fb-8f535cd98859"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
