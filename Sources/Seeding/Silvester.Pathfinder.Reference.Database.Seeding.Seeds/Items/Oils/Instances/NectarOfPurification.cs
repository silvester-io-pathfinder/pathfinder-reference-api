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
    public class NectarOfPurification : Template
    {
        public static readonly Guid ID = Guid.Parse("f391b39b-2c75-4b58-84cc-451b0a23dda1");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Nectar of Purification",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cd7a6246-e471-4f66-a1c2-8f95a4220cda"), "A shimmering liquid, nectar of purification is often stored in bottles similar to those used for vinegar. This oil casts a 1st-level purify food and drink spell over any food or drink onto which it's poured. The nectar evaporates as it takes effect, leaving the taste and texture of the food or drink unaltered.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("0118511c-9d7f-4d1c-98d5-1f0512514a17"),
                Name = "Nectar of Purification",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("061ada97-5e17-49f9-8d55-9ab230578ac5"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0db9ad08-bfb0-4ab8-87d9-021735be28c5"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("63d8ea10-4ee4-4d62-bed3-53967cab4005"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("728865cd-02f4-41be-ab39-ddcc490e6390"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("b3c00809-da72-42f3-9f74-45c9890562fc"), Traits.Instances.Oil.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dc8b99a-b2fa-46fe-8d99-c1b272af4541"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 561
            };
        }
    }
}
