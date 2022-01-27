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
    public class MendingLattice : Template
    {
        public static readonly Guid ID = Guid.Parse("0ec3c665-f7b5-44b4-8361-a3ff961b28ea");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Mending Lattice",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("043ad53f-61fa-4353-a7ba-0536c82be659"), "This lattice of reinforced iron is shaped into a perfect octagon. When you activate it, it negates the damage and instantly and completely repairs the affixed item.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("30e28545-7da9-4d58-8f39-b557ee961f4b"),
                Name = "Mending Lattice",
                Usage = "Affixed to a shield or weapon.",
                Level = 13,
                Price = 52500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6ae37a3e-8b3d-4952-90e5-db481a05fed5"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Trigger("The affixed item would take damage.")
                            .Requirements("You are a master in Crafting.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0a812f1a-5c47-416e-87df-927a3a4e8aec"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("0d7aec1d-8e3f-40e3-8028-3b9e0ff39dd0"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("7790d2bc-7c7d-411e-95ea-d1d650c6cd10"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("4deb8035-9d85-4ebf-ad20-2e7e8a860eda"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("276a8d36-f2e3-4537-b7f2-f210336454dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
