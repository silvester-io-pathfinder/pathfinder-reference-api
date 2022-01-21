using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class SteamWinch : Template
    {
        public static readonly Guid ID = Guid.Parse("aacbaa4a-940c-4c3f-b77a-d420a636b39d");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Steam Winch",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0cf63ec6-b590-4658-9274-536e7aaa3a1f"), "This hefty winch is powered by a small steam engine and includes a 100 ft. length of steel cable, which enables you to haul a heavier load than you could with a hand cranked winch or comealong (Lost Omens Pathfinder Society Guide 114). A steam winch allows you to slowly pull a heavy load (usually up to 50 Bulk) along a flat surface or up and down a vertical expanse.");
            builder.Text(Guid.Parse("9827f5d8-fc1f-4c26-a1f6-c8b58b457463"), "Attaching a steam winch to a device takes three Interact actions, while starting the winch (and getting it warm enough to operate) takes 10 minutes. Once in operation, a steam winch requires regular maintenance to function. Every twenty minutes, the boiler must be refilled and heat levels maintained.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("265eb162-632b-42ef-adb2-ef5de4a6067c"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("1fa1bcd6-411c-4999-9a1e-5d7af56acc44"), Traits.Instances.Steam.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2f36a536-874e-4458-a63c-aad0c9014dcb"),
                Name = "Steam Winch",
                Usage = "Operated with two hands.",
                Level = 8,
                Price = 42500,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("023a6731-6fd8-4be1-887d-c6b423d23aa6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 89
            };
        }
    }
}
