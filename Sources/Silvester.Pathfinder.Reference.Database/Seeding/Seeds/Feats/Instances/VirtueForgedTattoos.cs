using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VirtueForgedTattoos : Template
    {
        public static readonly Guid ID = Guid.Parse("be083937-8249-4e8f-841c-103c4ae4052f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Virtue-Forged Tattoos",
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
            yield return new TextBlock { Id = Guid.Parse("36b989f7-405c-420b-b943-8fe7acbd60c6"), Type = TextBlockType.Text, Text = "Your tattoos are a work of eldritch genius, a masterpiece of art, magic, and skin. Choose a 3rd-level arcane spell from the same school as your (feat: Arcane Tattoos), either a common spell or another to which you have access, including a lower-level spell heightened to 3rd level if you wish. You can cast that spell once per day as an innate arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3cf5313d-9655-45e9-acce-d59012dca87e"), Feats.Instances.OrnateTatto.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91c17aff-0fb5-40af-99bf-5e2b66b32f5e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
