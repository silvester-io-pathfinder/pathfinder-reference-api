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
    public class SaviorSpike : Template
    {
        public static readonly Guid ID = Guid.Parse("842a9d79-cfcc-448f-ae25-db5d8c7a8c57");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Savior Spike",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("76c3f860-8fad-4170-9e6f-eaac1f98a976"), "This pyramid-shaped spike is attached to an armor's chest piece. When you activate the spike, it shoots a strand of force to help you gain purchase. If you roll a success on the triggering attempt, you get a critical success instead (if you roll a critical failure, you get a failure instead).");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("9a7d251d-32a8-446e-bc7c-753d885254e6"),
                Name = "Savior Spike",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 700,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("45ad2941-b133-4a2e-9432-627b23cf8e77"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Trigger("You attempt to Grab an Edge but haven't rolled.")
                            .Requirements("you're an expert in Reflex.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("12cc2a16-b8c7-447a-bfd3-88f5564fae0d"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("d8da41c0-57a9-47da-ac06-16cf42618365"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e36821a8-c2d3-45ff-8305-beecde49ff14"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("c5f439c7-e818-4797-9440-38c2e0f485e3"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("fbfc7602-f0af-455c-b3ae-7d364bec18bc"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("faf7828a-1e25-4665-9142-b17b090fcbfe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
