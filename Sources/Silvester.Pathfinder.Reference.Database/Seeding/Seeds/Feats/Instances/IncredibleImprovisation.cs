using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IncredibleImprovisation : Template
    {
        public static readonly Guid ID = Guid.Parse("a25d4a6a-c3eb-4580-a2ba-a909bcc3d550");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Incredible Improvisation",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a check using a skill you're untrained in.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c3a9c67-8a31-4c93-a569-5c904bf2de0f"), Type = TextBlockType.Text, Text = "A stroke of brilliance gives you a major advantage with a skill despite your inexperience. Gain a +4 circumstance bonus to the triggering skill check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("69ac1889-7218-4962-9f82-7266c47d0dc6"), Feats.Instances.CleverImproviser.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adc6d7ad-e776-4b12-a3ef-c8a9efd1cc4a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
