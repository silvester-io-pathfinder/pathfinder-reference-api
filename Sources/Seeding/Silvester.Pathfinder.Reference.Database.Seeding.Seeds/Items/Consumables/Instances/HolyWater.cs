using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Consumables.Instances
{
    public class HolyWater : Template
    {
        public static readonly Guid ID = Guid.Parse("1e9201cd-cb98-41cd-a878-7489d92212e2");

        protected override Consumable GetConsumable()
        {
            return new Consumable
            {
                Id = ID,
                Name = "Holy Water",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c22af94e-7087-49b8-90e5-4d805e846a54"), "This vial contains water blessed by a good deity. You activate a vial of holy water by throwing it as a Strike. It�s a simple thrown weapon with a range increment of 20 feet. Unlike an alchemical bomb, it doesn�t add the manipulate trait to the attack made with it.");
            builder.Text(Guid.Parse("37824dbc-aae6-4176-937a-7f4a839d807f"), "Holy water deals 1d6 good damage and 1 good splash damage. It damages only fiends, undead, and creatures that have a weakness to good damage.");
        }

        protected override IEnumerable<ConsumableVariant> GetConsumableVariants()
        {
            yield return new ConsumableVariant
            {
                Id = Guid.Parse("e2e886a1-3935-4e90-a89d-80d14c0f9f60"),
                Name = "Holy Water",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f6146ee1-7b8d-4e54-90ad-5e11bddfe745"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Strike");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5ae382a8-2f00-439a-bf5b-689f75070d9f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("f71e877f-82c0-4aa3-9caf-bb1c273f1621"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("38783d83-fe99-4db8-b811-17147d423d4e"), Traits.Instances.Good.ID);
            builder.Add(Guid.Parse("801170dc-77a9-4aa1-a49c-6cc21d0d7e25"), Traits.Instances.Splash.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b5848c1-91c9-48a6-a8ee-8a2c10518554"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 571
            };
        }
    }
}
