using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class HornOfBlasting : Template
    {
        public static readonly Guid ID = Guid.Parse("d9602e8d-66f9-472e-a806-5ac624bdcb5b");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Horn of Blasting",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("15b43169-f79b-4e8a-99ab-5847af39bc75"), "A horn of blasting is a bright brass trumpet. It can be played as an instrument, granting a +2 item bonus to your Performance check.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("fd6291c9-2fdf-4bdb-8aaf-829b75bcf1fc"),
                Name = "Horn of Blasting",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                Price = 70000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4a685f16-7a1f-4d80-936f-002f5a6eabee"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per round.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("eef7f090-026f-40f0-8492-ca3fb0a97c2d"), "Blowing into the horn with destructive intent, you create a blast note targeting one creature within 30 feet. The blast deals 3d6 sonic damage (DC 28 basic Fortitude save).");
                            });
                    })
                    .Add(Guid.Parse("45116dbc-5fb5-4523-84d6-d2212ec668b9"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("f383d000-71e0-4eaa-8c1b-3a6f02adcc8e"), "You blow even louder to create an intense blast wave in a 30-foot cone that deals 8d6 sonic damage. Each creature attempts a DC 28 Fortitude save with the following effects.");
                            })
                            .RollableEffect(Guid.Parse("f9155637-a8e6-4796-8f2e-a6e30af8300a"), effect => 
                            {
                                effect.CriticalSuccess("The creature takes no damage.");
                                effect.Success("The creature takes half damage.");
                                effect.Failure("The creature takes full damage and is deafened for 2d6 rounds.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ea924319-ddd1-435a-a9f3-269307791b50"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("fba7ed69-5ccf-48a7-99ba-0351f0489c99"), Traits.Instances.Sonic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de1ebb28-9883-4468-88bf-a9d798369428"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 573
            };
        }
    }
}
