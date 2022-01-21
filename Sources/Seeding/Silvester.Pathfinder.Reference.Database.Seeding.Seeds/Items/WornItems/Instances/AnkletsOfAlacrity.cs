using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class AnkletsOfAlacrity : Template
    {
        public static readonly Guid ID = Guid.Parse("3036591f-7b1b-4995-a782-8a36eb288839");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Anklets of Alacrity",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e1a270a9-dd33-4c79-b00d-9798d96eda9c"), "These gem-studded golden anklets give you a +3 item bonus to Acrobatics checks. When you invest the anklets, you either increase your Dexterity score by 2 or increase it to 18, whichever would give you a higher score.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("46666eec-c4ac-4dfe-a72a-2c6d9b44c39e"), Traits.Instances.Apex.ID);
            builder.Add(Guid.Parse("aa3f354c-fafd-40c0-8a4c-275a58bdd9b9"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("e3944699-b148-4fcd-b51d-f172d136c2bc"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("4e989ee9-7474-4ac1-a2df-37be522ec219"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("27cc9adb-87c6-43df-8e18-92dbdc9c6117"),
				Name = "Anklets of Alacrity",
				Usage = "Worn anklet.",
				CraftingRequirements = "",
				Level = 17,
				Price = 1500000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("29844040-a9a0-43e8-bc11-9c0c47adaef2"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("Interact")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("8eb1959c-8d1d-46e5-a12f-0da70711ff54"), "ou click the anklets together, gaining a +20-foot status bonus to all your Speeds and the effects");
                             });
                     })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4d68634-3d28-4b05-96cf-f10d698757f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 603
            };
        }
    }
}
