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
    public class RingOfWizardry : Template
    {
        public static readonly Guid ID = Guid.Parse("a6b94612-437c-433f-9098-2ed51368a72a");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Ring of Wizardry",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e1a250f7-6c70-4d1a-bf6a-98918b4e6e78"), "This ring is made from the purest platinum and is covered in esoteric arcane symbols. It does nothing unless you have a spellcasting class feature with the arcane tradition. While wearing the ring of wizardry, you gain a +1 item bonus to Arcana checks and have two additional 1st-level arcane spell slots each day. You prepare spells in these slots or cast from them spontaneously, just as you normally cast your spells.");
            builder.Text(Guid.Parse("6d325286-f3e2-479c-829a-0c12a2badc70"), "If you take off the ring for any reason, you lose the additional spell slots. You can't gain spell slots from more than one ring of wizardry per day, nor can a single ring of wizardry grant spell slots more than once per day.");
            builder.Text(Guid.Parse("938f82c1-0984-4e19-89d1-451f1646d7de"), "If you can cast arcane spells in a variety of different ways (such as if you are a draconic bloodline sorcerer with the wizard multiclass archetype), you can divide the spell slots as you wish among your various sources of arcane spells.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4baf2078-1fad-48c2-aebf-6a76d9973664"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("760f2366-2426-4450-982b-739112f5be65"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("0877033b-24ac-4bb9-b0a3-d7bbb31b50b2"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("aada8631-197c-479a-8faa-8eb527472a91"), Traits.Instances.Invested.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("7351ae7d-f1e8-4e27-8b1c-39f16c468097"),
                Name = "Ring of Wizardry (Type I)",
                CraftingRequirements = "You have a spellcasting class feature with the Arcane tradition.",
                Usage = "Worn.",
                Level = 7,
                Price = 36000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("5f659f44-fdea-4337-88e8-a6835d8a3349"),
                Name = "Ring of Wizardry (Type II)",
                CraftingRequirements = "You have a spellcasting class feature with the Arcane tradition.",
                Usage = "Worn.",
                Level = 10,
                Price = 100000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("35b19b27-03c1-46e5-a5d8-a3529590fb11"), "The bonus is +2, and the ring grants two 2nd-level spell slots and one 1st-level spell slot.")
                    .Build(),
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("0bd0afdb-421f-4d22-91d8-cd709cfaecfa"),
                Name = "Ring of Wizardry (Type I)",
                CraftingRequirements = "You have a spellcasting class feature with the Arcane tradition.",
                Usage = "Worn.",
                Level = 12,
                Price = 200000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("9695d9d6-6cda-425b-8188-d951d8c848e9"), "The bonus is +2, and the ring grants two 3rd-level spell slots and one 2nd-level spell slot.")
                    .Build(),
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("1d1a0b67-be6d-496a-b060-7d6347b5f849"),
                Name = "Ring of Wizardry (Type IV)",
                CraftingRequirements = "You have a spellcasting class feature with the Arcane tradition.",
                Usage = "Worn.",
                Level = 14,
                Price = 450000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("93ee0020-b37c-4fee-81d3-4a6f6c226410"), "The bonus is +2, and the ring grants two 4th-level spell slots and one 3rd-level spell slot.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6864011d-8bfc-4c88-9cfd-7fb19303e139"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 615
            };
        }
    }
}
