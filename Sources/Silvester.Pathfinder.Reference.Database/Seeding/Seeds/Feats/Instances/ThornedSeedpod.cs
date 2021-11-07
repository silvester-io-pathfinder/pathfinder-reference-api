using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThornedSeedpod : Template
    {
        public static readonly Guid ID = Guid.Parse("c608ebda-f64d-438c-bc75-e878cce6cfa4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thorned Seedpod",
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
            yield return new TextBlock { Id = Guid.Parse("fe0af602-d9b9-4640-8087-0d49d50d11f8"), Type = TextBlockType.Text, Text = "When your seedpods strike a felling blow, they burst into viciously thorny vines. When you critically succeed at a seedpod (action: Strike), vines twist and stab your foe, dealing 1d4 persistent piercing damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5e36f8da-ff5a-4b50-9f78-0fe21aade1e8"), Feats.Instances.Seedpod.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77430f24-f49e-4ac8-b086-6ec887f318ba"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
