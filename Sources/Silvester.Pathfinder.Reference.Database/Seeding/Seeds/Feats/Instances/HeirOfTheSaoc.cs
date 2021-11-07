using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeirOfTheSaoc : Template
    {
        public static readonly Guid ID = Guid.Parse("210abafc-7c93-4907-82a3-b6ccdc950552");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heir of the Saoc",
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
            yield return new TextBlock { Id = Guid.Parse("cbf26f09-86ec-428b-8dbb-1bb0258ae7dd"), Type = TextBlockType.Text, Text = "In the past, you would have been a proud initiate of the Saoc Brethren. Today, you carry on their legacy. When you use (feat: Saoc Astrology), roll 1d4 instead; on a 1, you take a -1 penalty to the skill check. On any other result, you gain a circumstance bonus of that value (for instance, a +3 circumstance bonus on a 3)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("deda40f9-9e58-442d-b442-d069732633ee"), Feats.Instances.SaocAstrology.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e33f8b56-a573-48e6-8971-2220164d669c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
