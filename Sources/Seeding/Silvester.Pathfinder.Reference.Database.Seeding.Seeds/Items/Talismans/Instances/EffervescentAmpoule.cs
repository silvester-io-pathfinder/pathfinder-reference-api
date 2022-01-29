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
    public class EffervescentAmpoule : Template
    {
        public static readonly Guid ID = Guid.Parse("df04f4ae-b14f-4918-a1b6-f8ea5eb095c9");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Effervescent Ampoule",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("62bffc44-a6cc-46a6-8371-868c11a05e6e"), "Light spring water fizzes and bubbles within this small glass globe, spilling onto the affixed armor when activated. Until the end of your turn, the armor lets you move across water and other liquids as if they were solid ground. If you Stride or Step over a weight-sensitive pressure plate, you don't cause the plate to depress, which prevents you from triggering any device or hazard attached to the pressure plate. When the ampoule's effect ends, you sink, fall, break through flimsy ground, or land on pressure plates as normal for your current location.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("01183dfd-1b8b-4732-b495-d3179ac0d6e5"),
                Name = "Effervescent Ampoule",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 700,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ad1b0587-5c6b-44a0-a9be-66898d27b617"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Requirements("you're an expert in Acrobatics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a6faee2d-e7a0-4167-81df-7e762a1715fe"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("cf125a8e-6aa8-4b09-b380-35793cfd4a25"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3724edc6-611c-4eb7-ba4b-c03176c78c92"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("df1cd67b-694d-4aca-b871-8fc168cf53be"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a3b0b0a-41fd-4e30-9cfa-9ca32669d784"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
