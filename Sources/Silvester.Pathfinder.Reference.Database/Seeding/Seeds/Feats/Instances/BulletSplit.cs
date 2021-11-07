using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletSplit : Template
    {
        public static readonly Guid ID = Guid.Parse("15862dc7-e47c-4d30-ab8b-524bcfe6920b");

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
            yield return new TextBlock { Id = Guid.Parse("60990872-8804-43bf-829f-ad53917e96d0"), Type = TextBlockType.Text, Text = "You carefully align your weapon with the edge of your blade, splitting the projectile in two as you fire to attack two different targets. Make two (action: Strikes|Strike), one each against two separate targets. The targets must be adjacent to each other and within your weapon’s maximum range. Each of these attacks takes a –2 penalty to the attack roll, but the two count as only one attack when calculating your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("792b52dc-b192-455b-a87e-fa9e6c7ea9a5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
