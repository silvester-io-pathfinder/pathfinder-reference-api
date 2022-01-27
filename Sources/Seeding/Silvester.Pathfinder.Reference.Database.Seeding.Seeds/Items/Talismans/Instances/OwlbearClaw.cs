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
    public class OwlbearClaw : Template
    {
        public static readonly Guid ID = Guid.Parse("1d26180a-4723-473b-9793-1297c3e1f463");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Owlbear Claw",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("102e50ef-8061-457a-9f8b-27508285d4d6"), "This claw set in an iron clasp and chain isn�t always the claw of an owlbear. When you activate the claw, the triggering attack gains the weapon�s critical specialization effect.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("d4a677fc-8f92-4a18-8b06-bfa615d1effa"),
                Name = "Owlbear Claw",
                Usage = "Affixed to a weapon.",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("167af79c-0ba2-482b-b8b9-e3c7f8bef117"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You critically succeed at an attack roll with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c022764-5453-49d4-aa1d-0ae669bfbd51"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("3a98aa80-a394-4bc4-99eb-9e9a1a4f95ee"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("d8302262-c7bb-433e-b7b4-680841c841a6"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("c50930f6-10f0-4fc2-aa0a-624dcc8b2e77"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6f64e29-4a92-4ece-b54c-0912ae35c14c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
