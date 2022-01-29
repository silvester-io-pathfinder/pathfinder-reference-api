using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans.Instances
{
    public class IronEqualizer : Template
    {
        public static readonly Guid ID = Guid.Parse("1ec8599a-6fed-47a7-9607-d41d28da6605");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Iron Equalizer",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("95d8bcf9-6c40-44d4-a9c5-03a15d384cae"), "This small iron band has a shifting weight that helps equalize the affixed weapon's balance.When you activate it, you use Certain Strike, as the fighter feat(page 150).You must meet the normal requirements, including those of the press trait.");
            builder.Text(Guid.Parse("055de856-f0b5-4be0-a9dd-3efe0156bff8"), "If you have the Certain Strike feat, the failure effect increases to deal the weapon's normal damage.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("f7e139e4-db6b-41d7-9c3f-08a766ac9f8a"),
                Name = "Iron Equalizer",
                Usage = "Affixed to a weapon.",
                Level = 12,
                Price = 40000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3fd96ed6-b814-4216-987f-056eca83e4ef"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Certain Strike")
                            .Requirements("You are a master with the affixed weapons.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f855f56b-080d-4c8b-be6b-d54f6adaf19d"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("32d3eb76-bd1c-43a0-97f0-096c6f39a264"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("554ca918-9957-420d-9337-25d565e976ef"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("316b9695-3211-488b-9205-0aec71ff2d79"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52549bbf-b444-4a5c-ac7f-f5d3a28e693a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
