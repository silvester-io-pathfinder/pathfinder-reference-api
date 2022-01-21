using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalTools.Instances
{
    public class Sunrod : Template
    {
        public static readonly Guid ID = Guid.Parse("cad37b1b-7d1e-4a1a-acb4-23a9814683ab");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Sunrod",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8238f38f-f33e-4252-9f51-f0ec7ae0b938"), "A 1-foot-long, gold-tipped rod.");;
        }

        protected override IEnumerable<AlchemicalToolVariant> GetAlchemicalToolVariants()
        {
            yield return new AlchemicalToolVariant
            {
                Id = Guid.Parse("af3b690e-d5b7-408c-a762-e3bb00f78985"),
                Name = "Sunrod",
                Level = 1,
                Price = 300,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("535ae652-17cb-41e5-bd22-93ae14b3253e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("a54f16db-77c8-49ff-b585-4f71cfd94bdf"), "You strike the sunrod on a hard surface. For the next 6 hours, it sheds bright light in a 20-foot radius (and dim light to the next 40 feet).");
                            });
                    })
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2883281a-3750-4acf-80c8-3a0d58a47e26"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("42d58459-f267-41df-a333-41f30e18db06"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("80f0f992-196d-4946-9376-577e5464e531"), Traits.Instances.Light.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("64fa1397-8f70-4a14-9cfa-8f078fc31383"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
