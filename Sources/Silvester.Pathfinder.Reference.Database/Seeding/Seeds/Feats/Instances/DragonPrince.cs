using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonPrince : Template
    {
        public static readonly Guid ID = Guid.Parse("943cde70-de58-4c09-b911-57a4887c599c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Prince",
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
            yield return new TextBlock { Id = Guid.Parse("eb3c1a2c-c891-4918-acd2-dfde3a2330b2"), Type = TextBlockType.Text, Text = "The blood of the Dragon Kings runs strong in your veins. Your draconic heritage is clearly visible, with hair that is almost entirely crimson, azure, or the like, and that shines like a dragon’s scales. You can cast the (spell: dragon breath) sorcerer bloodline spell (page 403) as an innate arcane spell once per day, but you can use only the dragon breath that is associated with your heritage and that matches the energy type of your (feat: Dragon Spit) feat. At 12th level and every 3 levels thereafter, the spell is heightened by an additional spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6e8204cc-a627-4d55-8ec9-80167158ab3e"), Feats.Instances.DragonSpit.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15b25ffb-c420-4c11-b0ce-52d195cbd79a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
