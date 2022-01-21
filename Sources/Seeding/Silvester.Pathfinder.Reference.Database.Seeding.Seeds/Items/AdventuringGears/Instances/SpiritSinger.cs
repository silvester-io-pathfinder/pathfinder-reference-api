using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class SpiritSinger : Template
    {
        public static readonly Guid ID = Guid.Parse("fe2dce38-d121-461b-9efd-6011034acc6b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Spirit-Singer",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1779c7fd-dc25-4b84-9a5c-608b547b839b"), "Etheric spirit-singers create an eerie spectral sound based on the presence of spiritual essence and other ethereal energies. All spirit-singers can be used as musical instruments by manipulating the sensitivity to ethereal energies. However, they have an even greater benefit in areas heavy with spiritual essence. When played in the presence of a significant spiritual disturbance, such as a haunt or an incorporeal undead, a spirit-singer grants you a +1 item bonus to Performance checks. While playing a spirit-singer, you also gain a +1 item bonus to checks to detect a haunt or incorporeal undead, and you can roll a check to notice a haunt even if you aren't actively Searching for it, due to the distortions of the spirit-singer's music. A haunt or incorporeal undead that is intelligent enough to notice the effects it is having on the spirit-singer's music and that can't otherwise communicate with the living might choose to use the spirit-singer to do so if it wishes. For instance, it could try to guide the spirit-singer player towards a location by creating distortions in that direction or, if it understands language, it could try to answer questions by creating one distortion for yes and two distortions for no. Unless stated otherwise in its usage entry, a spirit-singer functions like a heavy musical instrument; rather than carrying it, the musician places the spirit-singer in a particular position and uses both hands to play.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0ed2a03e-95ae-47db-a1ce-c5d7b8bbd83d"),
                Name = "Spirit-Singer",
                Level = 5,
                Price = 15000,
                BulkId = Bulks.Instances.SixteenBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("c6185a8d-99b0-4760-8302-29fa350a927b"),
                Name = "Spirit-Singer (Handheld)",
                Level = 6,
                Usage = "Held in 2 hands.",
                Hands = "2",
                Price = 20000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("272438a3-e213-4120-8b51-f5f975e79dc8"), "This spirit-singer functions just like an incredible spirit-singer, except for its Usage and Bulk.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("4b1d802b-d058-416d-b164-82c31c68dc48"),
                Name = "Spirit-Singer (Incredible)",
                Level = 11,
                Price = 125000,
                BulkId = Bulks.Instances.SixteenBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5d1244e4-db7c-4a7f-9446-5045f3ae1814"), "This spirit-singer is fine-tuned to the point that you can analyze its song more intricately. Increase the item bonus to Performance checks near spiritual disturbances, and the item bonus to detecting haunts and incorporeal undead to +2. While playing the spirit-singer, you can notice haunts that normally require you to have a master proficiency in Perception to detect.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("557363a0-4bbd-4827-8461-9b48758add45"),
                Name = "Spirit-Singer (Incredible Handheld)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 12,
                Price = 165000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b51dd769-d648-474a-ae4f-10d4bd41ee02"), "This spirit-singer functions just like an incredible spirit-singer, except for its Usage and Bulk.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5a4b238-9a82-4021-ae1e-03817855be01"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 83
            };
        }
    }
}
