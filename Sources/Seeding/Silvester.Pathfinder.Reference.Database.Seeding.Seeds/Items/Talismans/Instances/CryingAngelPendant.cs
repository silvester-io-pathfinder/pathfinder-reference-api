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
    public class CryingAngelPendant : Template
    {
        public static readonly Guid ID = Guid.Parse("efb5f4b9-f3a4-423f-94f3-97124721d631");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Crying Angel Pendant",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ed24c388-baa2-410e-be62-d9a92cac223d"), "When you activate this alabaster pendant, your critical failure becomes a normal failure instead.");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("a7f94cdd-3788-4427-8637-7383e83762be"),
                Name = "Crying Angel Pendant",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 700,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d2d9aa34-c35c-4126-ba93-5195c8a5260a"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Trigger("You critically fail to Administer First Aid.")
                            .Requirements("You are trained in Medicine.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("26451edd-be09-4400-abf0-c414ecd699cd"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("c01ec1cc-fe1c-415c-976b-01a225b081f5"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("d6908e6d-255d-4487-8c75-02ef24523827"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("1d52f8f9-668e-4cb8-a328-cf4d0a9942da"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc6f2d7d-7960-4195-86db-e62ad4005af8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 566
            };
        }
    }
}
