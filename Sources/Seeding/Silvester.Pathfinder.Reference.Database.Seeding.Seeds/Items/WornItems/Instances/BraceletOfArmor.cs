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
    public class BraceletOfArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("8d4bc94f-a9fc-4ae7-b355-c10894fe973d");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Bracelet of Armor",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c9a1534d-2401-4ca8-bb4a-24613105d9cd"), "These stiff leather armguards grant you a +1 item bonus to AC and saving throws, and a maximum Dexterity modifier of +5. You can affix talismans to bracers of armor as though they were light armor.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f798e929-df05-4745-9add-5ee1cdebdcbb"), Traits.Instances.Abberration.ID);
            builder.Add(Guid.Parse("363c9e07-90ba-434e-8174-82786f91fb76"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("517c15a5-0e3b-4212-a805-f692b577b7ab"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("c8d08278-bdff-4710-9c0f-81d08f58f71c"),
                Name = "Barcelet of Armor (Type I)",
                Usage = "Worn bracers.",
                Level = 8,
                Price = 45000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()

                    .Build(),
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("e992f27a-6454-4f6b-b472-2b95bea28e6e"),
                Name = "Barcelet of Armor (Type II)",
                Usage = "Worn bracers.",
                Level = 14,
                Price = 400000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("574d467a-762c-4254-9204-b90fe0f26afd"), "The item bonus to AC and saves is +2.")
                    .Build(),
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("1f916d7f-d8b0-483b-a37e-d46c520f02f4"),
                Name = "Barcelet of Armor (Type III)",
                Usage = "Worn bracers.",
                Level = 20,
                Price = 6000000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("610edd75-8312-4a21-b177-614b66bcc2d6"), "The item bonus to AC and saves is +3.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a295775-a94a-4464-925f-84de22effd9e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 607
            };
        }
    }
}
