using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardMind : Template
    {
        public static readonly Guid ID = Guid.Parse("aad2704c-77c3-456e-895c-bdf3aa4d8d1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Mind",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can use this reaction even if the mental effect prevents you from using reactions.",
                Trigger = "Your turn ends.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c311388-fd72-4c09-9b00-b2682bf8053c"), Type = TextBlockType.Text, Text = "To protect the knowledge within your mind from intrusion or erasure, you ward yourself against a mental attack, temporarily delaying its effects. Until the end of your next turn, you ignore a single (trait: mental) effect that meets the requirement. You can suppress a particular effect using Ward Mind or (feat: Cognitive Loophole) only once, even if you have both feats." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cced1e9e-31ed-4303-acbf-a4312660346d"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("159bc17f-8e8c-439f-82e0-37a5fe06d8a6"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
