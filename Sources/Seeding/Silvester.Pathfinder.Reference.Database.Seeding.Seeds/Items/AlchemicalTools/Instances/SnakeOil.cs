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
    public class SnakeOil : Template
    {
        public static readonly Guid ID = Guid.Parse("fe623283-bc94-42a6-9a63-05fe74c06ab5");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Snake Oil",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("94cfd7f2-a8a2-44b5-9fbb-3f1893ebd964"), "Snake oil can be used to pretend to cure a symptom or affliction, even though the cause remains.");;
        }

        protected override IEnumerable<AlchemicalToolVariant> GetAlchemicalToolVariants()
        {
            yield return new AlchemicalToolVariant
            {
                Id = Guid.Parse("2e6c0996-4351-4d32-9aaf-0cfc4f16d348"),
                Name = "Snake Oil",
                Level = 1,
                Price = 200,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6f8b6993-d1a2-42e2-b7a2-5183b1198880"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("916e703d-ea1f-4d51-bdf2-9ac34500c265"), "You can apply snake oil onto a wound or other outward symptom of an affliction or condition (such as sores from a disease or discoloration from a poison). For the next hour, the symptom disappears and the wounded or afflicted creature doesn't feel as if it still has the wound or affliction, though all effects remain. A creature can uncover the ruse by succeeding at a DC 17 Perception check, but only if it uses a Seek action to specifically examine the snake oil's effects.");
                            });
                    })
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("afd0b602-9091-460b-a604-7beb3510fea9"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("8a5c98b1-6050-4f55-b36a-84994727e108"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("4a59ca8c-7b59-4cb7-bfe3-3afdfc151793"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
