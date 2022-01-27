using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Scrolls.Instances
{
    public class ScrollOfIllusoryDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("439e5146-0b27-4fa9-bcda-684dfd1fa72d");

        protected override Scroll GetScroll()
        {
            return new Scroll
            {
                Id = ID,
                Name = "Scroll of Illusory Disguise",
                SpellId = Spells.Instances.IllusoryDisguise.ID
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("124649cb-21c2-4820-b5b7-4cb37a4e5fd7"), "This scroll can cast illusory disguise as a 1st-level spell.");
        }

        protected override IEnumerable<ScrollVariant> GetScrollVariants()
        {
            yield return new ScrollVariant
            {
                Id = Guid.Parse("4dc2e057-db04-4f8c-9f46-df43bf2888ed"),
                Name = "Scroll of Illusory Disguise",
                CraftingRequirements = "Supply one casting of illusory disguise.",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fed70ad1-281e-408c-8f5e-64deb9806564"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a8737bd5-682d-4ab7-b977-64cd04412058"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("6d84f2a0-2514-4fc4-a904-61e85506d92b"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("796913d8-a7f1-4430-9cac-6a759f31fa5f"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("b8a1d3fb-bd4c-4221-8d21-cc45ec25f14c"), Traits.Instances.Scroll.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00ad854d-6a42-49c0-8982-d06964b5fdd9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 565
            };
        }
    }
}
