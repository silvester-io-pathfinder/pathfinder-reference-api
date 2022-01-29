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
    public class RicochetShot : Template
    {
        public static readonly Guid ID = Guid.Parse("92cff5e1-c14c-4b09-87ab-326ecfa024fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Shot",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe1fad3e-ba8c-4c1a-bcd3-15aa8014868c"), Type = TextBlockType.Text, Text = $"You bounce your shot off a nearby surface to strike your opponent from an unexpected angle. When determining whether a target has cover from your ranged attack with a firearm or crossbow, you can choose one solid surface within your weapon's first range increment to ricochet your shot off of. If you do, you determine the target's cover from the point where you ricochet your shot instead of from you." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("24c0fb93-ddc2-4c94-aada-9678ddc9585c"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("f15a4aa7-3766-4be6-b741-80db7a9eed5b"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50c01cb2-c8fe-44d8-821c-8bca517775ed"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
