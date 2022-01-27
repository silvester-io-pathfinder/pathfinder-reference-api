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
    public class GrimTrophy : Template
    {
        public static readonly Guid ID = Guid.Parse("a8528053-d369-4a29-9ae4-3d4ca2393dd3");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Grim Trophy",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4c137a3c-f5ff-473e-a33f-7045e1aff9ca"), "This talisman comes in many forms, most often a severed piece of a humanoid creature displayed in some gruesome manner. When you activate the trophy, select two targets and compare your Intimidation check result to both of their DCs.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("86a77ffd-a81a-4751-b599-64c50a88551e"),
                Name = "Grim Trophy",
                Usage = "Affixed to armor.",
                Level = 7,
                Price = 5500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("356fa818-72ea-4af8-89ad-237a727ecdf1"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Trigger("You attempt an Intimidation check to Coerce or Demoralize, but you haven�t rolled yet.")
                            .Requirements("You are an expert in Intimidation.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b38d66a6-7f53-4574-b3f7-048c273f1b0d"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e5cd0863-f271-4efa-8d64-6d10f9586ac1"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6d960a68-5ef6-4837-ad0b-16448030b432"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d9f0be7f-4d3e-4ba7-8391-29b26fe401c8"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2da1891f-5671-4933-93a7-4c6f84495963"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
