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
    public class EverburningTorch : Template
    {
        public static readonly Guid ID = Guid.Parse("ea36809e-4cf3-433b-9b3a-05db5a2aa04b");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Everburning Torch",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4c90b1af-191e-4b26-aa50-24783b97d81d"), "An everburning torch is one of the most common applications of permanent magic. This torch sheds light constantly, requiring no oxygen and generating no heat. The flame can be covered or hidden, but can't be smothered or quenched.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("9efde8db-bfd3-4a31-bff1-15438fd03704"),
                Name = "Everburning Torch",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 1500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c4ab4c66-7798-4281-8f41-bba3a733eb47"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("3588f79c-94bf-4b5b-b2dd-e94f6d4e1663"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("383c982c-58c1-475e-90b0-a9e5d5feef3e"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e988ad1-c1b8-4ede-ba02-c7ef79b8d3ce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 573
            };
        }
    }
}
