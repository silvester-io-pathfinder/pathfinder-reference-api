using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Oils.Instances
{
    public class AntimagicOil : Template
    {
        public static readonly Guid ID = Guid.Parse("795d050a-096f-4bdb-ae20-233ae95c8776");

        protected override Oil GetOil()
        {
            return new Oil
            {
                Id = ID,
                Name = "Antimagic Oil",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f3bc8da2-8a28-4a24-941c-79124e798315"), "This oil contains energy that repels nearly all types of magic. When you apply this oil to armor, the creature wearing the armor becomes immune to all spells, effects of magic items (the wearer's and those of others), and effects with the magical trait for 1 minute. The oil affects neither the magic of the armor nor the fundamental runes of weapons attacking the wearer. Magical effects from a source of 20th level or higher, such as a deity, still function on the armor's wearer.");
        }

        protected override IEnumerable<OilVariant> GetOilVariants()
        {
            yield return new OilVariant
            {
                Id = Guid.Parse("4cc26ed8-9d22-49cc-ba90-a9c0b536125c"),
                Name = "Antimagic Oil",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 20,
                Price = 1300000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8c15c22c-dcb7-434f-8018-226ee0e5bacc"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6bc4826d-5830-49dd-b43b-21bac1b2bd22"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("9bf1d4ab-0982-44b2-88e7-4ae05e5952a1"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("2b3a2da2-5e41-482a-aec1-af0390c28eae"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("1a0f7cd1-036e-4a9d-8226-0eea05b6f41c"), Traits.Instances.Oil.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14cc7270-060c-41a5-ae73-d239defe900c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 561
            };
        }
    }
}
