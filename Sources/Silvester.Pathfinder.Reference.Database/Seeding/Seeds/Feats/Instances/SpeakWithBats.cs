using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpeakWithBats : Template
    {
        public static readonly Guid ID = Guid.Parse("97c7e7c5-5db0-4e61-aacf-30230a86f4fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Speak with Bats",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0478763e-bd19-4366-9d62-2ea43a70158e"), Type = TextBlockType.Text, Text = "You can ask questions of, receive answers from, and use the Diplomacy skill with bats. You gain a +2 circumstance bonus on all Diplomacy checks to (action: Make an Impression) on bats or (action: Request) something from bats." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("51deaac3-ac2f-46ad-81db-7e091e890515"), Heritages.Instances.NykteraSprite.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b4c6b53-0835-4068-9440-4431e25d40f4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
