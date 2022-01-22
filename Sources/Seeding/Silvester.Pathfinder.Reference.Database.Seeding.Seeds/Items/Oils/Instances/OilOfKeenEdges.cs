using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Oils.Instances
{
    public class OilOfKeenEdges : Template
    {
        public static readonly Guid ID = Guid.Parse("024cca23-3ded-4631-93b9-62d6cae858de");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Oil of Keen Edges",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("385895c4-03e3-4971-ba64-f23678fa49a8"), "When this silvery salve is applied to a melee weapon that deals piercing or slashing damage, the weapon grows sharper and more dangerous for 1 minute, granting it the benefits of the keen rune.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("84325f7e-b99c-4ac2-b5d5-38331e1376da"),
                Name = "Oil of Keen Edges",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 11,
                Price = 25000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c7b1ed8d-d5f0-4590-aa6f-c60cb3a50185"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("af364f31-9775-48b9-b32d-f2872b5b6754"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("b0ac0d79-b1a0-4ead-963a-bfa13a07ea20"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("f198c54f-52d7-42a7-82a4-f2461c74fbe9"), Traits.Instances.Oil.ID);
            builder.Add(Guid.Parse("d1f1e169-3d6b-464c-b7f4-6a2da6c3233a"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b818fb35-f04e-4545-94e3-56900d3a9c4d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 561
            };
        }
    }
}
