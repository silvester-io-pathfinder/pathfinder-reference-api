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
    public class VipersFang : Template
    {
        public static readonly Guid ID = Guid.Parse("2f1dad8f-bfb1-41db-9a28-ab121db2252c");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Viper's Fang",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f659aa92-8672-4867-94c8-544ee9976d79"), "When you activate this resin-strengthened viper skull, you make an Attack of Opportunity against the triggering creature.");
            builder.Text(Guid.Parse("ada587a0-9264-44ef-9be7-05f970b3b8b6"), "If you have Attack of Opportunity, you can activate the viper's fang as a free action.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("4b23ee72-9c1d-49df-b66a-30e9eb9e044f"),
                Name = "Viper's Fang",
                Usage = "Affixed to a weapon.",
                Level = 14,
                Price = 85000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("759f6ab9-08e6-44d5-973c-02da632a8ac1"), ActionTypes.Instances.Reaction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("A creature within your reach uses a manipulate or move action, makes a ranged attack, or leaves a square during a move action it's using.")
                            .Requirements("You are a master with the affixed weapon.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5f7e2f24-3c61-4abe-8ebd-66e40bc7cdbf"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e94d538b-82b5-49e0-be40-5d32418e8059"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("a1a937ef-42ab-42a5-b080-8ca200940b6a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("fca119a4-4d19-425e-ae00-4f8234e0a4b1"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0e6316f-3586-4d9e-912e-f4000cf18807"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 569
            };
        }
    }
}
