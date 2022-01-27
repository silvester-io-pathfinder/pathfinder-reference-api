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
    public class JadeBauble : Template
    {
        public static readonly Guid ID = Guid.Parse("660fd44e-cf89-4aa6-b706-2b38aae76c79");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Jade Bauble",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("afaadb5c-5019-4e5b-bd59-36bddddb1df2"), "This bit of jade is usually carved in the shape of a duelist, or sometimes a multi-armed creature. When you activate the bauble, it magically draws the attention of foes. Until the start of your next turn, enemies within the reach of the weapon the talisman is affixed to are flat-footed.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("22dc7b5d-cb69-44ce-b721-6f074361fa59"),
                Name = "Jade Bauble",
                Usage = "Affixed to a melee weapon.",
                Level = 8,
                Price = 10000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8172b826-ee2f-4b0c-b030-eca236b9fd62"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Requirements("You are a master with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("85a24cd6-35ee-4f5a-a1d3-c1102fba362f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("412db440-9bb3-489e-9a55-4e2995fcebe6"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("81af7bb1-6f80-4bc2-9c66-b8e4996619cf"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3e1fc635-b15f-4780-b479-21344e16d967"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("4eadc856-4c2a-4be8-993c-530c2100a15c"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f97c54e-af7e-4d8d-b98e-d4765753869d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
