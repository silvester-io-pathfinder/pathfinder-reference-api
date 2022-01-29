using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class SpinedShield : Template
    {
        public static readonly Guid ID = Guid.Parse("355de2ce-42ac-4e17-9f52-cf297e10cc74");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Spined Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("45c8ae8b-d1ff-4f0e-a0c0-290f3104957c"), "Five jagged spines project from the surface of this steel shield (Hardness 6, HP 24, BT 12). The spines are +1 striking shield spikes. When you use the Shield Block reaction with this shield, the spines take the damage before the shield itself does. When the shield would take damage (after applying Hardness), one spine snaps off per 6 damage, reducing the damage by 6. The shield takes any remaining damage. When there are no spines left, the shield takes damage as normal.");
            builder.Text(Guid.Parse("a0ef331a-6114-4b16-a0ca-55f35876da62"), "When all the spines are gone, you lose the ability to attack with them until the spines regenerate the next day.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4f262d66-f264-4ef1-8ca8-18feb1119e00"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("d4dff08a-13eb-4d46-9e3c-349953548e0e"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("b742b3d4-8bc7-4d69-9687-8144df459761"),
                Name = "Spined Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                BrokenThreshold = 12,
                Hardness = 6,
                HitPoints = 24,
                Price = 36000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c42ee88f-39ba-45cf-a9de-dfc63a21106e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("14ceca6e-99c3-40a7-bd03-84632dac2da8"), "You shoot one of the shield's spines at a target. A fired spine uses the spikes' statistics, but it is a martial ranged weapon with a range increment of 120 feet.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1169f7f4-9eca-46ee-8bf0-cf8f70904b18"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 588
            };
        }
    }
}
