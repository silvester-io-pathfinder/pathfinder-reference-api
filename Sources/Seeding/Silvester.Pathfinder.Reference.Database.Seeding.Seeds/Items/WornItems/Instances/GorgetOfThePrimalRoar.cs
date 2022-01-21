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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class GorgetOfThePrimalRoar : Template
    {
        public static readonly Guid ID = Guid.Parse("1c3d570e-41c2-464c-be04-709159e70821");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Gorget of the PrimalRoar"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("78f94d53-69f8-4302-a570-15eb31d0a736"), "This engraved darkwood gorget seems to vibrate with ferocity, granting you a +2 item bonus to Intimidation checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c2f1476-062b-40d4-bb1e-cca365519c65"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b61cacc9-16c1-4bd1-8a0a-1635b4fe1399"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("9d562194-a284-4a27-95ba-b3295ed17267"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("b8a04b94-572e-48f8-8abc-5192cc03eac8"),
                Name = "Gorget of the Primal Roar",
                Usage = "Worn collar.",
                Level = 11,
                Price = 125000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("623dcc92-173c-419e-8e79-f148ba086343"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Requirements("You're in a non-humanoid form via polymorph effect.")
                            .Frequency("Once during the duration of each polymorph effect.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("4e946c67-bbbd-4040-bcdd-f7fabf511515"), "You unleash a bestial roar, attempting a single Intimidation check compared to the Will DCs of all enemies within 30 feet to impose the effects below. Though this activation has the command component, you can issue this command without the need for language.");
                            })
                            .RollableEffect(Guid.Parse("2ea034d3-d574-4d11-9f9b-a007629c3eff"), effect =>
                            {
                                effect
                                    .CriticalSuccess("The creature is frightened 2.")
                                    .Success("The creature is frightened 1.")
                                    .Failure("The creature is unaffected.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9b6f058-1922-45f8-a06c-c952a39518d0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 611
            };
        }
    }
}
