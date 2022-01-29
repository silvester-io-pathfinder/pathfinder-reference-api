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
    public class BronzeBullPendant : Template
    {
        public static readonly Guid ID = Guid.Parse("a5a48636-6543-4785-8d03-083adec3e03b");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Bronze Bull Pendant",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5f79b841-f53c-40d2-86f8-f1c05db077c9"), "This pendant is forged from grainy steel and depicts a snorting bull's face. The pendant must be attached to the chest area or on a shoulder guard. When you activate the pendant, you gain a +2 status bonus to the Athletics check to Shove, and if you roll a critical failure on the check, you get a failure instead.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("55b247b8-d61d-454f-93cb-c5e609e0c8b7"),
                Name = "Bronze Bull Pendant",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 700,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("10c26683-36be-4737-986c-eb0c9383b380"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Trigger("You attempt an Athletics check to Shove, but you haven't rolled yet.")
                            .Requirements("You are trained in Athletics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c9fe535b-dad2-40e5-8be4-9fec210cee00"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("299ae550-96eb-431a-b031-459002e0ff1a"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("4eb8a3f9-cf5b-480a-a2e7-3561b4d66078"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c1546535-927a-48b5-a0a9-c449da3b5c3a"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d0725ff-3194-4ace-88e0-26b1ed637c08"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
