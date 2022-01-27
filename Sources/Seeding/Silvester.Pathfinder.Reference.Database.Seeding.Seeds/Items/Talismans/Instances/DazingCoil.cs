using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans.Instances
{
    public class DazingCoil : Template
    {
        public static readonly Guid ID = Guid.Parse("9d56b1f8-2ac3-4012-be95-779b207ad78d");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Dazing Coil",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("08afe303-e056-483c-8400-68b7d4d02ae5"), "This knot of copper wire reshapes itself in a new pattern every time its affixed weapon deals damage.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("949c7b4c-bf57-487d-a563-a5310c0fbe39"),
                Name = "Dazing Coil",
                Usage = "Affixed to a weapon.",
                Level = 14,
                Price = 90000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("93811af6-26d9-4ad0-b70f-ca1474a5f893"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You deal damage to a flat-footed creature with the affixed weapon.")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("dff9671f-a826-4c8f-af22-5fef99755d85"), "When you activate the coil, the damaged creature must succeed at a DC 31 Will save or be stunned 1. If it critically fails, it instead becomes stunned 2.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("de8ce322-ec6e-43d2-8899-dcd7514329bc"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("f290c074-e9c3-44ce-b94b-b0ba9d2a601b"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("d7332778-298b-4f0f-8087-0ff87bde47a2"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c70b206e-9cba-4bf2-989e-94fcb2e66726"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("333634c2-e63f-46b9-97cb-3306a6216d32"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
