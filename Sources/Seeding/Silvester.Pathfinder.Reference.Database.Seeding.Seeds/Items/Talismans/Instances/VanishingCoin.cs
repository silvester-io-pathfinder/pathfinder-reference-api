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
    public class VanishingCoin : Template
    {
        public static readonly Guid ID = Guid.Parse("8eea042c-e3ae-4b81-a1a0-9bf94e4a4876");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Vanishing Coin",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("df82f1b5-1fe9-4191-b5e5-c86eafe8d660"), "This copper coin dangles from a leather strip strung through a hole drilled in the center. Until activated, the coin becomes invisible for a few seconds at random intervals every few minutes. When you activate the coin, it casts a 2nd-level invisibility spell on you, lasting until the end of your next turn.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("3ae213d5-3dbf-4ad4-aab6-875dfc7dd75e"),
                Name = "Vanishing Coin",
                Usage = "Affixed to armor.",
                Level = 10,
                Price = 16000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ad66537a-d83d-4acb-a352-1b4c3ab20112"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You attempt a Stealth check for initiative, but you haven�t rolled yet.")
                            .Requirements("You are a master in Stealth.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3e8c6ba5-d9a6-431f-a33b-3f64503fb27f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("1eee7d13-a738-4674-bb48-17f0b9386685"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("76facc54-70ef-42c8-abb4-534834403da6"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("fb7bdf3c-a302-42ff-836c-5dc2ec417728"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fde8cba-7828-4e6f-b919-810488732761"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
