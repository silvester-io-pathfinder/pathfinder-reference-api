using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DazzlingBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("d686128c-ea2e-4b4f-bb95-cefdd2bacca6");

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
            yield return new TextBlock { Id = Guid.Parse("18771754-2b07-4931-b9b5-ef9eb121ab2d"), Type = TextBlockType.Text, Text = "Your tricks discombobulate your opponent, leaving spots in their vision from the bright flash of your gunshot reflected straight into their eyes (or other visual organs). Attempt a Performance check against the target creature’s Will DC and make a ranged firearm (action: Strike) against that target. If the (action: Strike) deals damage to the target creature and you succeed at the Performance check, the creature is dazzled for 1 round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("92384dc5-088b-49be-ba5e-4095866c37ee"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f067d5c8-fe0d-41a7-94fd-56a2beccf7fb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
