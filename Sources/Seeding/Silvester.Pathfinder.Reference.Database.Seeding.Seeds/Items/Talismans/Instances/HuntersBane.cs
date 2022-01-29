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
    public class HuntersBane : Template
    {
        public static readonly Guid ID = Guid.Parse("51903da5-273d-4135-bfe3-58bce9abfc94");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Hunter's Bane",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bf47834d-4b15-403e-8644-f0e5998b3864"), "This talisman is a ring of dried, interwoven leaves. When you activate the hunter's bane, you sense the exact location of the attacker, making it hidden from you instead of undetected. If the attacker is behind lead, the hunter's bane fails and is wasted.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("28c9ab05-4efd-4e58-928d-c226fd8bd039"),
                Name = "Hunter's Bane",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 600,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("46331560-51bc-4e3f-b06c-e0a05bcd1d4e"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("An undetected enemy hits you with an attack.")
                            .Requirements("You are trained in Survival.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("38722730-0804-46fd-b352-5d4d89ad0daa"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("5a0ccb5f-9d76-420b-bfc7-1945149b101a"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("f3426049-aa68-41a0-96aa-f685d2f16570"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("87dad3dd-9d35-4d1b-8b52-c39146f95076"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c047970-2ebb-4aa3-98fb-7ba70a55ba89"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
