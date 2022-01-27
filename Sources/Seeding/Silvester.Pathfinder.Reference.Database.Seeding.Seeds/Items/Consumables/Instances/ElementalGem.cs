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
    public class ElementalGem : Template
    {
        public static readonly Guid ID = Guid.Parse("13f7a061-915e-4fda-87f9-342d719ce922");

        protected override Consumable GetConsumable()
        {
            return new Consumable
            {
                Id = ID,
                Name = "Elemental Gem",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3b30a737-1b6b-4469-ad34-957a33827164"), "You shout the name of an elemental lord and dash this glassy gem against a hard surface to activate it. It cracks open, casting a 5th-level summon elemental spell to summon forth an elemental you control as long as you spend an action each round to Sustain the Activation.");
            builder.Text(Guid.Parse("9a973403-9783-45d4-825a-ad516642a2b1"), "This gem comes in four varieties: transparent for a living whirlwind, light brown for a living landslide, reddish orange for a living wildfire, and blue-green for a living waterfall.");
        }

        protected override IEnumerable<ConsumableVariant> GetConsumableVariants()
        {
            yield return new ConsumableVariant
            {
                Id = Guid.Parse("0befa3b3-66ca-414a-b71d-a956ec636867"),
                Name = "Elemental Gem",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 20000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("485587fe-9bcb-4aa3-849e-5303636adc11"), ActionTypes.Instances.TwoActions.ID, "Activate", action => 
                    {
                        action.Kind("Command, Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7db916d3-dd71-4997-a59c-c99a1623b2dd"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("6dfb2862-dabd-4eba-88e7-cf4aab27253f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("44c5b537-ae07-43b8-b09f-c3c19539c0bf"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1b3c93a-302d-4116-b7f1-e6da9e22c97a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 570
            };
        }
    }
}
