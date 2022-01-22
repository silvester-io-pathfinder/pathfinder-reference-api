using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class TritonsConch : Template
    {
        public static readonly Guid ID = Guid.Parse("14ebb176-fc55-4c8e-89f5-48b84d558336");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Triton's Conch",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("dd076d2c-0a33-4660-a273-8273b7285d59"), "");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("882da1aa-2198-4d13-b2b7-4367956c48c9"),
                Name = "Triton's Conch",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                Price = 64000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("750adc7b-1f03-4866-840d-49a45e40e95a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Traits(traits => 
                            {
                                traits.Add(Guid.Parse("9348ce61-a397-4df7-bd31-9952fbfd1e43"), Traits.Instances.Auditory.ID);
                            })
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("0c915a29-a46c-408a-97f2-b84ed0313d04"), "You can raise the conch to your lips and blow into it, letting out a long, rumbling note. For the next minute, you and all allies who were within 30 feet of you when you activated the conch gain a +2 item bonus to Athletics checks to Swim and can breathe under water.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("cdf02f61-fcc3-4d7b-b0fa-1a28aadfc0a3"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("1603f7bb-10a4-4962-8ad4-87a81e7ed382"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92c5c1bd-47b0-4593-a086-fe49f04c7c6b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 576
            };
        }
    }
}
