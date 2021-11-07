using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DazzlingBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("938a6f2e-c9f3-4f0d-845d-8d19454005ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dazzling Bullet",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d158f267-1f4f-4358-8ea9-586b70279550"), Type = TextBlockType.Text, Text = "Your tricks discombobulate your opponent, leaving spots in their vision from the bright flash of your gunshot reflected straight into their eyes (or other visual organs). Attempt a Performance check against the target creature’s Will DC and make a ranged firearm (action: Strike) against that target. If the (action: Strike) deals damage to the target creature and you succeed at the Performance check, the creature is dazzled for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bb967aa3-0fef-4ea3-bb74-e60170b3f4e2"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("326ff42e-2e85-4d2c-a9ca-2a84f8d59741"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
