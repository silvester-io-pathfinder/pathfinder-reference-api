using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChosenOfLamashtu : Template
    {
        public static readonly Guid ID = Guid.Parse("0096c5b0-68b3-4b88-b2c7-c4d3f8d19551");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Chosen of Lamashtu",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("374e054e-13ae-4c7b-a9c6-9546d9ec0b0d"), Type = TextBlockType.Text, Text = "You bear the favor and blessings of Lamashtu, the Mother of Monsters. She has bestowed a mutation upon you, granting you the benefits of another heritage. Choose one goblin heritage that you do not already have; you gain that heritage and its benefits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.WorshipSpecificDeity(Guid.Parse("24f8aabf-c630-4a9e-a6ab-459c1df10aa5"), Deities.Instances.Lamashtu.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19e94cf9-c27d-4b4e-877c-e82f509399d6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
