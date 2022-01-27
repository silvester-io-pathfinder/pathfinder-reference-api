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
    public class ScrollOfGlitterdust : Template
    {
        public static readonly Guid ID = Guid.Parse("1787c50b-62b6-4c3c-8d32-f5de60258ed1");

        protected override Scroll GetScroll()
        {
            return new Scroll
            {
                Id = ID,
                Name = "Scroll of Glitterdust",
                SpellId = Spells.Instances.Glitterdust.ID
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fd66d906-5b59-4377-82b4-70e9b2399d8a"), "This scroll can be used to cast glitterdust as a 2nd-level spell.");
        }

        protected override IEnumerable<ScrollVariant> GetScrollVariants()
        {
            yield return new ScrollVariant
            {
                Id = Guid.Parse("391be349-0676-45ec-afed-c81ba7e2cfaa"),
                Name = "Scroll of Glitterdust",
                Usage = "Held in 1 hand.",
                CraftingRequirements = "Supply one casting of glitterdust.",
                Hands = "1",
                Level = 3,
                Price = 1200,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c7a960d0-0b12-40fa-bea7-45e4fbe489d3"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action.Kind("Cast a Spell");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8c8e3092-3c9f-474f-a46d-4248808cf6d2"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("3ebadcec-da22-41c7-88e0-486a214b1401"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("1297116f-37df-49c5-95cb-37a768da3866"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d884de62-4467-44a2-9cdd-e92c74034779"), Traits.Instances.Scroll.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13bfbbc0-8cfa-4327-9bb2-db051cbb6f09"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 565
            };
        }
    }
}
