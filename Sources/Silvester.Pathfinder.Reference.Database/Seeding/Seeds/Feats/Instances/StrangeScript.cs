using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrangeScript : Template
    {
        public static readonly Guid ID = Guid.Parse("12c4b592-0d60-4814-9b26-9504c19f4345");

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
            yield return new TextBlock { Id = Guid.Parse("5239edcc-6407-4f77-8cfc-951911e0fc0e"), Type = TextBlockType.Text, Text = "You have such familiarity with obscure texts that you can compel them to reveal their secrets. Once per day, you can touch a single text (such as a tome, a wall of hieroglyphics, or something similar) and understand its meaning for 1 hour. If the text is in multiple languages, you gain the ability to understand them all for only the purposes of reading the text. If the text is in a code or cypher, you don&#39;t automatically understand the text, but you gain a +2 circumstance bonus to checks to decipher it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4ee8f06d-d2fe-4fe4-ab34-89d4a75ae3fc"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eff0d84b-06bd-4579-9b3f-36cc5b17ea39"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
