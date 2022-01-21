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
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class CapeOfTheMountebank : Template
    {
        public static readonly Guid ID = Guid.Parse("69e590a6-725d-4561-9684-50676f648e0d");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Cape of the Mountebank",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f9627aaf-f892-4f42-be83-8c7ccceab56f"), "This bright red-and-gold cape is often interlaced with glittery threads and serves as a distraction. While wearing the cape, you gain a +2 item bonus to Deception checks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5fd91ed8-f792-4c5c-829f-4493dea60250"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f49685bb-fe3b-4901-aee0-43b3266f769c"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("826bf95f-67c5-4852-90e2-e74fe2cdb7c4"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("85eecad0-b727-483e-acc6-29003ae7b327"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("affd7b11-f12f-4fde-b5e3-0ac073e03f2d"),
				Name = "Cape of the Mountebank",
                Usage = "Worn cloak.",
				Level = 10,
				Price = 98000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a98a34f6-30f5-46c5-9400-4337042b776d"), ActionTypes.Instances.TwoActions.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interacct")
                            .Frequency("Once per day.")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("a0017d54-7fb0-4e2a-8848-4580e0a01602"), "You cast dimension door. The space you leave and the one you appear in are filled with puffs of smoke that make anyone within concealed until they leave the smoke or the end of your next turn, at which point the smoke dissipates. Strong winds immediately disperse the smoke.");
                            });
                    })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6b915f4-136b-4699-b622-e6dc865fd9b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 607
            };
        }
    }
}
