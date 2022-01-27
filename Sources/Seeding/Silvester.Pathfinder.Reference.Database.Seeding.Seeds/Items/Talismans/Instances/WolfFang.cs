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
    public class WolfFang : Template
    {
        public static readonly Guid ID = Guid.Parse("efc47c41-7fad-4de0-9b6f-529c521ec382");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Wolf Fang",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4fa4e631-8a6d-48b9-8827-ad8cc600b31a"), "This wolf canine is bound in a strip of leather and tied to a buckle or strap of a suit of armor. When you activate the fang, you deal bludgeoning damage equal to your Strength modifier to the target of your Trip. If your Trip would already deal physical damage that doesn�t include an ability modifier, add your Strength modifier to that damage.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("90cc83a3-c4b4-47ae-8d91-f330763db996"),
                Name = "Wolf Fang",
                Usage = "Affixed to armor.",
                Level = 1,
                Price = 400,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1cfdc886-7799-4913-a20e-33d6832a0233"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Trigger("You successfully Trip a foe.")
                            .Requirements("You are trained in Athletics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a92b3b2d-3a6c-40f0-8c9c-bffeeae72290"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("c7762225-0708-4087-a6f4-4781a332b886"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("ba159495-5908-41fa-b86b-020a6a5ffd90"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("405083f0-e9fb-45d8-a41c-be7a93f6c236"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c74e400b-8565-4396-9b85-720778b2cd0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 570
            };
        }
    }
}
