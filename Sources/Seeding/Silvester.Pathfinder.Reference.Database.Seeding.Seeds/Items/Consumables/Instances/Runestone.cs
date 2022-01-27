using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Consumables.Instances
{
    public class Runestone : Template
    {
        public static readonly Guid ID = Guid.Parse("d04b26af-9b3a-46c6-9cb0-bc67071a4785");

        protected override Consumable GetConsumable()
        {
            return new Consumable
            {
                Id = ID,
                Name = "Runestone",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("402dc508-8559-4e85-9bbb-f0ceb6f11665"), "This flat piece of hard stone is specially prepared for etching a magical fundamental rune or property rune. You can etch only one rune upon a stone. Once the stone is etched, it gains the magic school trait of the rune etched upon it. When a rune is transferred from the runestone to another object, the runestone cracks and is destroyed. The Price listed is for an empty stone; a stone holding a rune adds the Price of the rune.");
        }

        protected override IEnumerable<ConsumableVariant> GetConsumableVariants()
        {
            yield return new ConsumableVariant
            {
                Id = Guid.Parse("d4f7bda7-acb9-4c65-aaba-eeaeb9b3f0fa"),
                Name = "Runestone",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8a81a537-4b34-426e-8842-79a549ee214e"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("19b2e99b-502b-45f7-abd7-4f89dd702881"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("335097a3-99fd-4355-b3d4-4853ca838ead"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 570
            };
        }
    }
}
