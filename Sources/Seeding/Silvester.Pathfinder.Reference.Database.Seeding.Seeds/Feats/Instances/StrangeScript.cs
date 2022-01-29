using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrangeScript : Template
    {
        public static readonly Guid ID = Guid.Parse("416b5379-77c9-42b1-8f7c-0e7b7e94868d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strange Script",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b8f3f03-6a85-456b-b8a2-f98b78e1716c"), Type = TextBlockType.Text, Text = $"You have such familiarity with obscure texts that you can compel them to reveal their secrets. Once per day, you can touch a single text (such as a tome, a wall of hieroglyphics, or something similar) and understand its meaning for 1 hour. If the text is in multiple languages, you gain the ability to understand them all for only the purposes of reading the text. If the text is in a code or cypher, you don't automatically understand the text, but you gain a +2 circumstance bonus to checks to decipher it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5bf83914-77e5-4e10-a625-7c660bab297a"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fc0b4bb-a0e9-4d9d-9f71-8de8cf2e25b5"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
