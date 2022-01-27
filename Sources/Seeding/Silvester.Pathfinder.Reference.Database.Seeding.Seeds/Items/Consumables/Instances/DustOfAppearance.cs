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
    public class DustOfAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("021c7ba8-d9d1-43e9-a603-12713e602577");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Dust of Appearance",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d4c9d092-d8a7-4c66-81ac-f7ac3c59e44b"), "Stored in a small reed, this powder looks like a fine metallic dust. When you fling it in the air, it coats all creatures in a 10-foot burst centered on a point within 5 feet of you. For 1 minute, the coated creatures can�t be concealed or invisible, nor can they benefit from mirror image or similar abilities that create illusory duplicates. Any illusions in the area of 3rd level or lower are revealed as such, although this does not end their effect.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("8ec42522-f478-497e-806c-3234fbd8608f"),
                Name = "Dust of Appearance",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 5000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5f3b87ee-ca8e-4a68-b4a9-73b538694945"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("49c99151-6b2a-43d3-89c7-eb609b824ace"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("91acb796-0212-4a1b-9502-16239bae1677"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("29e1b67d-aa56-40a7-927d-a7b4e2a2d713"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1c57887-badd-4229-b2d2-e07c6b2b1d2c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 570
            };
        }
    }
}
