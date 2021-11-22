using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NeverTire : Template
    {
        public static readonly Guid ID = Guid.Parse("34c902d2-99e2-40db-957b-c42888f81ccd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Never Tire",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would gain the fatigued condition.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ecdda6b7-abaf-4c10-b7cb-c10c360300cd"), Type = TextBlockType.Text, Text = "As long as you have an audience, you can continue to perform. Indeed, you must – you have an obligation to your fans! You delay the effects of the fatigued condition for 1 minute or until you are no longer observed by the required creatures, whichever comes first. If the fatigued condition has a duration, the duration begins to elapse only after the delay. You can't further delay or prevent the fatigued condition after this ability ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c335f1b-c7c3-4b0d-96a1-47a5c43bd87a"), Feats.Instances.CelebrityDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6eda6078-7e5d-46d6-a1a1-0947c49fd146"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
