using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletSplit : Template
    {
        public static readonly Guid ID = Guid.Parse("36e76baa-71a5-4a1b-aef7-ab2450a67f3a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullet Split",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("11c7f07b-2bdb-4de0-a36c-ae91572da23b"), Type = TextBlockType.Text, Text = "You carefully align your weapon with the edge of your blade, splitting the projectile in two as you fire to attack two different targets. Make two (action: Strikes|Strike), one each against two separate targets. The targets must be adjacent to each other and within your weapon’s maximum range. Each of these attacks takes a –2 penalty to the attack roll, but the two count as only one attack when calculating your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed1073a3-f96e-448c-83d3-5689c24ce5d8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
