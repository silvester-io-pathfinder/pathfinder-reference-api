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
    public class BerserkersCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("760957a2-7528-409a-816a-bc102347d40a");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Berserker's Cloak",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e49bbde4-d5cb-41a1-befb-db8229a0aecf"), "This bearskin includes the head and bared teeth of the mighty creature from which it was taken. When worn, the cloak drapes over your head and around your shoulders, imbuing you with a bear's ferocity. If you have the Rage action, while raging you grow jaws that deal 1d10 piercing damage and claws that deal 1d6 slashing damage and have the agile trait. This transformation is a morph effect, and both the jaws and claws are unarmed attacks in the brawling weapon group. You gain the benefits of a +1 weapon potency rune and a striking rune with these attacks (gaining a +1 item bonus to attack rolls and increasing the weapon damage dice by one).");
            builder.Text(Guid.Parse("4f431f91-c672-484f-9a1d-929f146a57cb"), "If you have an animal instinct (see the barbarian on page 82) and the bestial rage instinct ability, instead of gaining these unarmed attacks, your unarmed attacks from the bestial rage instinct ability gain the benefits of a +2 weapon potency rune and a greater striking rune (granting a +2 item bonus to attack rolls and increasing the weapon damage dice by two).");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a5743360-2bd0-4254-9392-39cb1b4ca5ec"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("cb39aa85-e33b-439a-a2bf-bc0e476dd535"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("18dede22-49a4-4787-9237-446432b1f2ca"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("0d6e0bb7-7376-43cd-96f4-8db756cf27ab"),
                Name = "Berserker's Cloak",
                CraftingRequirements = "You are a barbarian with the animal instinct.",
                Usage = "Worn cloak.",
                Level = 12,
                Price = 200000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("95ae8aa1-705e-4b4f-8a4f-464cbedf6153"),
                Name = "Berserker's Cloak (Greater)",
                CraftingRequirements = "You are a barbarian with the animal instinct.",
                Usage = "Worn cloak.",
                Level = 18,
                Price = 4000000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("8010ac40-c1f5-4443-9ec6-11b7482dcd34"), "You gain the benefits of a +2 weapon potency rune and a greater striking rune, or a +3 weapon potency rune and a major striking rune if you have an animal instinct and the bestial rage instinct ability.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a725da0e-6333-44a7-ad33-75e8d1d81f7b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 606
            };
        }
    }
}
