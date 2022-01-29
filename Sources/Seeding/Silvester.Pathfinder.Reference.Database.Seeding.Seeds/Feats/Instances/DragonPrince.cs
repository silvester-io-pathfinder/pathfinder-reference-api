using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonPrince : Template
    {
        public static readonly Guid ID = Guid.Parse("4bde7c1b-7539-4eab-85db-5a276bddf2df");

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
            yield return new TextBlock { Id = Guid.Parse("c6352257-019f-4977-8667-caa2a077def6"), Type = TextBlockType.Text, Text = $"The blood of the Dragon Kings runs strong in your veins. Your draconic heritage is clearly visible, with hair that is almost entirely crimson, azure, or the like, and that shines like a dragon's scales. You can cast the {ToMarkdownLink<Models.Entities.Spell>("dragon breath", Spells.Instances.DragonBreath.ID)} sorcerer bloodline spell (page 403) as an innate arcane spell once per day, but you can use only the dragon breath that is associated with your heritage and that matches the energy type of your {ToMarkdownLink<Models.Entities.Feat>("Dragon Spit", Feats.Instances.DragonSpit.ID)} feat. At 12th level and every 3 levels thereafter, the spell is heightened by an additional spell level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("14bdbb59-7336-47eb-97f6-c0949796baaa"), Feats.Instances.DragonSpit.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ece21010-2756-4e5e-aa43-b3f780f17a32"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
