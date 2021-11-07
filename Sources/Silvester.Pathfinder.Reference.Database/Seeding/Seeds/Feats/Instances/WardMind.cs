using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardMind : Template
    {
        public static readonly Guid ID = Guid.Parse("87e4dcd4-c129-4da4-861c-430079672cc3");

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
            yield return new TextBlock { Id = Guid.Parse("58676053-ac59-49a8-b107-b57abc8f7968"), Type = TextBlockType.Text, Text = "To protect the knowledge within your mind from intrusion or erasure, you ward yourself against a mental attack, temporarily delaying its effects. Until the end of your next turn, you ignore a single (trait: mental) effect that meets the requirement. You can suppress a particular effect using Ward Mind or (feat: Cognitive Loophole) only once, even if you have both feats." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("66cef4ef-a93b-4824-803a-05c56cf0c2c6"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54630157-d8d7-4eaf-918b-dd686c63ef44"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
