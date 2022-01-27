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
    public class DispellingSliver : Template
    {
        public static readonly Guid ID = Guid.Parse("763b4c90-e4e7-4aa3-a584-7b7568a6e683");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Dispelling Sliver",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9b0c99c8-d852-46b8-83e4-1a3e769a3253"), "Made from a treated sliver of cold iron, this talisman allows you to counteract magical effects. When you activate the dispelling sliver, it attempts to counteract a single spell active on the target (counteract modifier +29), with the effects of an 8th-level dispel magic spell.");
            builder.Text(Guid.Parse("28cd6278-31b7-483a-a1fd-f488ed871d65"), "If you activate the talisman on a successful Dispelling Slice, the talisman attempts to counteract all spells active on the target.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("7c114aaf-74d2-418f-b67b-704de092a3a7"),
                Name = "Dispelling Sliver",
                Usage = "Affixed to a weapon.",
                Level = 17,
                Price = 240000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8519d5bf-1603-4bd9-8be0-1d0b98f951a3"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("Your strike damages a target.")
                            .Requirements("You're a master with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e4b4a282-120d-4c8e-b4b6-b91e9333346f"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("96351d7c-58c2-4cdb-9b2f-645d90a0c2d8"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("6dfdf3f6-1ce1-42eb-8ec6-b80cf2b1e04b"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("5850501e-8d54-4191-a5d1-533e24535e35"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0075344a-ca9b-4061-9dad-eb04baa020ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
