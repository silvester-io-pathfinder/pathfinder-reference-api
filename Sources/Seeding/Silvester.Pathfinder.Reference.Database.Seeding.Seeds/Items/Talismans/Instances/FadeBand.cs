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
    public class FadeBand : Template
    {
        public static readonly Guid ID = Guid.Parse("131209db-8330-4d70-b2de-b9afb89a62a0");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Fade Band",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f8ddff5a-eab5-4105-bb23-0af7f9c9f1ba"), "This thin, silvery wire wraps around your armor.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("0a586512-5cec-4c54-a767-03560558e790"),
                Name = "Fade Band",
                Usage = "Affixed to armor.",
                Level = 12,
                Price = 32000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4103af29-1587-45b2-a9ed-c76dc7322ee5"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Trigger("An attack misses you.")
                            .Requirements("You are a master in Stealth.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e1a77546-5127-47b6-93a2-d8b09547c097"), "When you activate the band, it casts a 2nd - level invisibility spell on you.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1f48286f-d145-4129-9c06-3c1481053c49"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("62235770-bcbf-43ab-a7df-c7db810c61ff"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("c103e335-4e86-411e-8673-bd3199921b54"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("4a9754a5-a02a-48d0-8603-12563e94692b"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbcfdaaa-53bb-49c9-933e-5af6238d83c8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
