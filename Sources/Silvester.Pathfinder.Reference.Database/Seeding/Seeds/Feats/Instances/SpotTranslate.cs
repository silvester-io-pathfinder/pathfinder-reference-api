using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpotTranslate : Template
    {
        public static readonly Guid ID = Guid.Parse("15c1bfb3-6aa4-4484-94fa-4bb0e026abd9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spot Translate",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Another creature within 60 feet uses a linguistic effect in a language you understand.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6da6a4da-9b1f-48cb-866f-ba09275f18be"), Type = TextBlockType.Text, Text = "You interpret a creature’s words, repeating their message in a different language that you know. If the triggering effect’s targets speak either the original language or the one you translated into, they are affected." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3a8d35bd-213c-4aa1-95fb-3b2844e738f9"), Feats.Instances.LinguistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("678dd802-1c0b-4896-93d1-ec57f6e019f9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
