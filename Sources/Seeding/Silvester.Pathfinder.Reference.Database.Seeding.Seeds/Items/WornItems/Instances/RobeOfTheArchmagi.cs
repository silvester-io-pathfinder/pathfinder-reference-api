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
    public class RobeOfTheArchmagi : Template
    {
        public static readonly Guid ID = Guid.Parse("93b2bfd1-15e5-4cb2-8a35-699e06f22b07");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Robe of the Archmagi",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("03027c67-68b1-4282-ab96-531c46d1e9a6"), "Embroidered with fine silver thread in ornate arcane patterns, these robes come in one of three colors depending on their attuned alignment. Good robes are white, neutral robes are gray, and evil robes are black. An evil or good robe gains the appropriate trait. The robes benefit only characters who can cast arcane spells and whose alignment on the good-evil axis matches that of the robe. If your alignment does not match that of the robe, or you are not an arcane spellcaster, you are instead stupefied 2 while wearing a robe of the archmagi. This condition can�t be removed in any way until you remove the robe.");
            builder.Text(Guid.Parse("588c2738-f6b9-45d9-b54e-487b6f21fb75"), "The robes are +2 greater resilient explorer�s clothing, and they grant a +1 circumstance bonus to saving throws against arcane spells and resistance 5 to damage from arcane spells.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5fce27d6-4e35-4020-bb83-8290aa9e815b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e6748d4f-bfb2-4653-bc9d-a76e7096e889"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("4a28dfbd-c5b4-4ba0-8071-9f74e24c1eb7"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("a7c09e69-8b4b-43bc-bc04-69f1f4319b57"), Traits.Instances.Invested.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("9316da10-a4c4-4d1e-a6ae-e87ff2db5e8d"),
                Name = "Robe of the Archmagi",
                CraftingRequirements = "You are an Arcane spellcaster.",
                Usage = "Worn garment.",
                Level = 15,
                Price = 650000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                     
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2c5d5c92-328d-4453-8fad-be1d1d0b5d65"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You attempt a saving throw against an Arcane spell, but you haven't rolled yet.")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("65a13412-77ec-4b7d-9767-8b87a9028b53"), "You automatically succeed at your save against the triggering arcane spell.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("0ca8e61b-cee4-4137-88fe-2923e658cbe9"),
                Name = "Robe of the Archmagi (Greater)",
                CraftingRequirements = "You are an Arcane spellcaster.",
                Usage = "Worn garment.",
                Level = 19,
                Price = 3200000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a97a21e4-b3b9-4101-a390-095bb8bc3bfe"), "The resistance against arcane spells is 10. You can activate the robe when you or an ally within 30 feet attempts a saving throw against an arcane spell, and the robe grants either you or the ally a success on the triggering saving throw; you still can activate it only once per day.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("41ab45ad-5f55-4f8b-b9ab-bd5cbb377432"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You attempt a saving throw against an Arcane spell, but you haven't rolled yet.")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("b957f57d-298f-4b42-9b55-1c45192ccfbc"), "You automatically succeed at your save against the triggering arcane spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7eaf24bb-f03a-4990-90b7-8c22a17aaf97"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 616
            };
        }
    }
}
