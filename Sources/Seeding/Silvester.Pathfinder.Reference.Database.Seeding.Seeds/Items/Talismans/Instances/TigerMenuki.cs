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
    public class TigerMenuki : Template
    {
        public static readonly Guid ID = Guid.Parse("e8ca6aa9-8e59-4842-b76f-76f0416012eb");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Tiger Menuki",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f1e230c8-0e1a-4ea9-b90e-b9e5ae213bad"), "This tiger formed of pewter snarls viciously from your weapon's grip. When you activate the tiger, the affixed weapon gains the sweep trait for the triggering attack and all other attacks for 1 minute.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("f9e2aafe-9ed0-4edb-bc81-99658b3d5aed"),
                Name = "Tiger Menuki",
                Usage = "Affixed to a weapon.",
                Level = 5,
                Price = 3000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f5ba689e-d848-482f-99e6-c3936b1636eb"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You Strike with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5d7d9377-7d83-49b2-8d58-9662ec2ecede"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("7e2ea041-2b5d-454c-a123-8a603898e7f5"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d3d503c1-5375-43c4-818c-729a7820c51a"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("447235be-6b37-4df6-9d52-a80b934f60cc"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb512c81-2251-4022-9494-8304c6264d0a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
