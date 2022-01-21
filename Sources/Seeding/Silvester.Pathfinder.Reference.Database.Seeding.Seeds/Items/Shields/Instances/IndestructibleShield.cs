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
    public class IndestructibleShield : Template
    {
        public static readonly Guid ID = Guid.Parse("cfba1157-8685-45c7-ab2d-88e570fb2ff6");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Indestructible Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e552ad7d-cb83-49a7-beeb-23db09f0ad14"), "An indestructible shield is a high-grade adamantine shield (Hardness 13, HP 90) that can withstand just about any damage. It can be damaged only by a disintegrate spell (roll damage as if against a creature that failed its save) or by an artifact tied to destruction, such as a sphere of annihilation.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9763b08c-d47a-4234-a672-2e52afbae818"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("51056274-1765-4fde-870d-3cf8d6518ed8"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("6dea8464-e4f0-4018-b7ea-3a3b52c06b9b"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("d990a857-fc91-46bd-aabf-3b037df541b9"),
                Name = "Indestructible Shield",
                CraftingRequirements = "The raw materials must include at least 4,400 gp of adamantine.",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 18,
                Hardness = 13,
                HitPoints = 90,
                Price = 2400000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cbe69c6-3a58-4177-8cb6-09c0802c0e0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 588
            };
        }
    }
}
