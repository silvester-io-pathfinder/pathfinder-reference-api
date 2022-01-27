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
    public class GhostDust : Template
    {
        public static readonly Guid ID = Guid.Parse("58e04838-a3b6-4cb5-b876-5debfc44be9c");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Ghost Dust",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9582bba0-1b0b-4ad8-aa36-10f1e3db8a9e"), "This small vial is filled with a grayish-green dust rendered from dried ectoplasm. When you activate the dust, it casts a 4th-level invisibility spell on you. This comes into effect before you move during the triggering action.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("10335fd0-b333-4303-a077-f8800939a3a7"),
                Name = "Ghost Dust",
                Usage = "Affixed to armor.",
                Level = 16,
                Price = 180000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0bbb6c06-9991-457a-8cfc-996904659878"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You use an action with the move trait.")
                            .Requirements("You are legendary in Stealth.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0e7b7d4e-b95b-42fd-80d5-8208941f4337"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("96932c88-3dcb-451d-9d83-0033f3748e1e"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("14993ecf-3b1a-478c-a25a-76e80cb4368c"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d814277d-4649-4b5c-b1d9-b93cc11a76e4"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bef2a03-39b8-4475-bfde-c1f353fdd82e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
