using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationProjectileLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("ebe73aa4-020c-46f7-8053-1aff142ff822");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Projectile Launcher",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("faf9f76f-7618-410b-86e7-2848298e1d01"), Type = TextBlockType.Text, Text = "Your construct has a mounted dart launcher, embedded cannon, or similar armament. Your innovation gains a ranged unarmed attack that deals 1d4 bludgeoning or piercing damage (you choose when you pick this modification). The attack has the (trait: propulsive) trait and a range increment of 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f64351e-158e-4c57-bb23-ea2bc44392a1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
