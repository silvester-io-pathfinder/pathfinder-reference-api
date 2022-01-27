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
    public class FeatherStepStone : Template
    {
        public static readonly Guid ID = Guid.Parse("f6599896-edfa-4934-9bad-017288cd215f");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Feather Step Stone",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("03c46bdb-047b-4013-8278-6299f4ca1754"), "This stone, usually shaped as a cabochon, is a small chunk of amber with a bit of feather or a flying insect caught within it. When you activate the stone, you ignore the effects of any difficult terrain and greater difficult terrain you move through until the end of your turn.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("30fd123b-eee4-4f00-8be2-77a237801780"),
                Name = "Feather Step Stone",
                Usage = "Affixed to armor.",
                Level = 3,
                Price = 800,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6da18890-16c6-4f45-ba60-779a0a31db9c"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You Stride or Step.")
                            .Requirements("You are an expert in Acrobatics.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("50d5dad1-4841-4ab6-9629-2be18e8bb700"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e29c3d85-6d88-4511-94a8-66d66e4a03ad"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("77166b45-b4e1-444f-bc7f-ba9a915776b4"), Traits.Instances.Talisman.ID);
            builder.Add(Guid.Parse("b877b2dd-c8be-424d-bf6e-a026daaaf128"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e625df8a-dc2c-4b88-b825-e26ee6b60f27"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 567
            };
        }
    }
}
