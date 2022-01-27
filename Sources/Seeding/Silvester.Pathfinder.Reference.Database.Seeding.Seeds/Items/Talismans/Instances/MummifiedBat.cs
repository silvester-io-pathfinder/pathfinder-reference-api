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
    public class MummifiedBat : Template
    {
        public static readonly Guid ID = Guid.Parse("83df6f16-907e-4c6c-97f3-bf84c741c6ed");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Mummified Bat",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f0c7bb79-a646-4fdc-a8e7-f2c978c2d8c2"), "This talisman is the magically treated corpse of a tiny bat bound in papyrus. When you activate the bat, the affixed weapon detects vibrations around you and guides your perception. You gain the benefits of the fighter Blind-Fight class feat (page 149) for 1 minute.");
            builder.Text(Guid.Parse("f1a61c52-6f7e-47c8-b035-dfc4023442fe"), "If you have the Blind-Fight feat, you gain imprecise echolocation with a range of 30 feet for 1 minute. This makes creatures that would be undetected by you because you can�t see them hidden instead.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("4f4e2aff-5286-4945-ae7e-fa93b9278428"),
                Name = "Mummified Bat",
                Usage = "Affixed to a weapon.",
                Level = 10,
                Price = 17500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8c01d961-2cab-4520-98dd-7cc8787bac85"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Requirements("You are a master in Perception.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e93d558b-674a-4d21-81ff-8727a08d8600"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e9b28281-c46c-4b8c-85ce-a747698c0915"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("732f631b-5b3a-4531-928a-c2799affe182"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("00964127-c6c8-4a98-ac42-c2b5c8bdd4d9"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cba4c5fb-e004-4946-ad60-ae94ec6f52d1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
