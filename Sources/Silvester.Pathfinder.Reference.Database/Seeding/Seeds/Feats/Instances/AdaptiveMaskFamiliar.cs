using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdaptiveMaskFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("f079a737-788f-4588-9ed7-23dcf6c67b26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adaptive Mask Familiar",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ddb300e-812d-4b1d-b67b-53b49aee0faa"), Type = TextBlockType.Text, Text = "Your mask familiar adapts quickly to material form, allowing it to gain more familiar and master abilities. You select four master and familiar abilities each day instead of two." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19ae10c9-5d18-4f6a-b3ed-2b46f15bd011"), Feats.Instances.MaskFamiliar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26e89cbc-1a1c-4887-99e0-7c946c0309a5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
