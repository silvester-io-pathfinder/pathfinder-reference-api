using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ControlledBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("3f922405-b907-4e26-a0b8-cdf8d6c8016f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Controlled Bullet",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73678503-a688-4ce4-a803-81c4092423cb"), Type = TextBlockType.Text, Text = "You create a direct magical connection with your beast gun, allowing you to guide the beast gun’s next shot by taking control of the projectile directly, steering it through the air, and swerving and veering it to continue to hit target after target. Make a beast gun (action: Strike) against a creature within the first range increment. On a hit, the shot tears through the target and continues toward another target you can see. You make a (action: Strike) against this new target. The new target must be no farther from the previous target than a distance equal to the beast gun’s range increment. For example, the new target must be within 150 feet of the previous target when attacking with a (item: drake rifle). On a hit, you can direct the bullet toward a new target." };
            yield return new TextBlock { Id = Guid.Parse("6c1f5b19-5a67-4570-8501-5455f3663673"), Type = TextBlockType.Text, Text = "You can continue to make (action: Strikes|Strike) against new targets in this same way until your attack misses, at which point your shot dissipates. You can’t make a (action: Strike) against a target you already attacked during this use of Controlled Bullet, but you can otherwise continue to make attacks against valid targets until you miss. Each attack counts toward your multiple attack penalty, but don’t increase your penalty until you’ve made all your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("42848576-3d04-4f5e-966d-5dcd56be8ffd"), Feats.Instances.BeastGunnerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f343b05-adcf-407b-b54b-22d62b088dd2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
