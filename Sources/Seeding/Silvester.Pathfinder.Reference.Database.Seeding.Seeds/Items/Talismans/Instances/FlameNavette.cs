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
    public class FlameNavette : Template
    {
        public static readonly Guid ID = Guid.Parse("f41750ea-f277-45e8-8227-e58b22dbe99e");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Flame Navette",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8e9a1e97-8165-4996-8585-38a4f561df0f"), "This piece of bronzite is shaped like an oval with points at both ends. It has a carved flame at its center and is traditionally worn over the heart. You can activate only one flame navette per day. When you activate the navette, you gain the benefit of the fighter�s Determination class feat, with a counteract modifier of +22. If you have the Determination feat, you can use your own modifier if it�s better.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("9c049974-f7a0-4117-a505-b60712846527"),
                Name = "Flame Navette",
                Usage = "Affixed to armor.",
                Level = 16,
                Price = 180000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("76853db2-d256-4bad-8fee-4163f2dc569a"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Requirements("You�re an expert in Will saves.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("37e9f9f2-8ee0-47d1-b12a-a402c9aae0e7"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("78a19a6a-94d0-47bb-8762-d54de672b15e"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e2b2006a-16cf-433e-9cd4-3ad00dadbd36"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("56f1b6f9-4839-4237-8894-0906e439b8b6"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec131f15-3fc1-4dfb-a51d-387e5e0e0910"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
