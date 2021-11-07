using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritualGuides : Template
    {
        public static readonly Guid ID = Guid.Parse("2f076e35-0e5a-475d-8708-a32b08530306");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spiritual Guides",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail, but don't critically fail, a Perception check or a skill check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1625c1c8-c842-442d-8195-1933496f1fc8"), Type = TextBlockType.Text, Text = "Though no one sees them and only you can hear them, the spirits around you constantly chatter, save when you are raging. Sometimes they’re even helpful. You can heed the spirits’ guidance to reroll the triggering check, using the second result even if it’s worse." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("5e18dcfa-a2ad-4a7e-8f4c-b9e680b39a92"), Instincts.Instances.SpiritInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39dcf52e-cafa-4b71-8b51-c3bd1cf3e80d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
