using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class WovenwoodShield : Template
    {
        public static readonly Guid ID = Guid.Parse("56fa082f-abac-4a9b-bac6-93b4f78734dd");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Wovenwood Shield"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4e543a9e-27bc-4df3-921d-93b518c21c4d"), "This magically reinforced wooden shield is made by skilled Ekujae mages, who've developed unique spells for reinforcing wood collected from their forests. Each shield is embossed with the signatures of the mage and artisan who crafted it.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1065ef21-ee40-4596-ad22-f24f90c0f63f"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("fd74197a-d864-42a4-ae84-8b52d646d786"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("4c79e48c-6b9c-461c-bdc9-9c1018257e00"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("1b14b1d8-e5eb-4618-88aa-55a538ec19fc"),
                Name = "Wovenwood Shield (Minor)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 4,
                BrokenThreshold = 20,
                Hardness = 5,
                HitPoints = 40,
                Price = 8500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("8c32f42b-0bf5-46ed-a58e-dcf689506950"), "This shield has Hardness 5, Hit Points 40, and Broken Threshold 20.")
                    .Build()
            };


            yield return new ShieldVariant
            {
                Id = Guid.Parse("f7289280-d693-4fce-8289-0a3dc8578487"),
                Name = "Wovenwood Shield (Lesser)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                BrokenThreshold = 32,
                Hardness = 8,
                HitPoints = 64,
                Price = 30500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0d84a3e7-8ee7-42a9-8183-67e8ec201f97"), "This shield has Hardness 8, Hit Points 64, and Broken Threshold 32.")
                    .Build(),
            };


            yield return new ShieldVariant
            {
                Id = Guid.Parse("4f166ae1-2aad-483b-ad0d-18abff6a2e7a"),
                Name = "Wovenwood Shield (Moderate)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                BrokenThreshold = 40,
                Hardness = 10,
                HitPoints = 80,
                Price = 85000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e889fb12-31fa-4e2f-9a22-c1be7f7e8d1c"), "This shield has Hardness 10, Hit Points 80, and Broken Threshold 40.")
                    .Build(),
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("85796abc-d164-416f-9498-c35a54423952"),
                Name = "Wovenwood Shield (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 13,
                BrokenThreshold = 52,
                Hardness = 13,
                HitPoints = 104,
                Price = 255000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c6efeafc-6fef-431b-962d-7c7217b2d784"), "This shield has Hardness 13, Hit Points 104, and Broken Threshold 52.")
                    .Build(),
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("887d2fd4-2d05-493e-ba35-a9e224e1da57"),
                Name = "Wovenwood Shield (Major)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 16,
                BrokenThreshold = 60,
                Hardness = 15,
                HitPoints = 120,
                Price = 850000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("794f8319-4c03-4358-9dba-49251fbd8719"), "This shield has Hardness 15, Hit Points 120, and Broken Threshold 60.")
                    .Build(),
            };

            yield return new ShieldVariant
            {
                Id = Guid.Parse("b9f88cac-414d-49de-9064-9772346ca8ff"),
                Name = "Wovenwood Shield (True)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 19,
                BrokenThreshold = 68,
                Hardness = 17,
                HitPoints = 136,
                Price = 3400000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d1ec317b-0c54-4ebc-9126-358c9e633e2c"), "This shield has Hardness 17, Hit Points 136, and Broken Threshold 68.")
                    .Build(),
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e958bd1-af3b-46ec-938a-71adfe62be83"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 81
            };
        }
    }
}
