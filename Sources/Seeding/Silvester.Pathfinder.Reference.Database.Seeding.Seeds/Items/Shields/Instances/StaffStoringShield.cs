using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class StaffStoringShield : Template
    {
        public static readonly Guid ID = Guid.Parse("ea8242f8-4880-4ab3-9b8e-8848ed0f1efa");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Staff-Storing Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("91e2229e-2d6e-4516-8f6a-a6e785a70a45"), "This magically reinforced wooden shield (Hardness 6, HP 36, BT 18) normally has a blank face. It can absorb a staff and transform between a shield and staff. When you prepare a staff, you can hold it up to the shield, at which point the items will merge, and the shield's face becomes an image corresponding to the type of magic, such as a skull for a staff of necromancy.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("706f93a8-13c5-40cf-977a-fcfb554d438c"), Traits.Instances.Extradimensional.ID);
            builder.Add(Guid.Parse("81c4857b-5669-4642-b4d1-7c9e024d99f0"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("e891f889-1357-4cab-8ab0-0d82b09d84f9"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("4b86e62b-1a7d-40aa-9c2c-c7b8721d3d05"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("754a21ed-1733-43f6-9528-b5f164991bd3"),
                Name = "Staff-Storing Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                BrokenThreshold = 18,
                Hardness = 6,
                HitPoints = 36,
                Price = 35000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("002717aa-e352-4b79-80a3-9cf807fd3314"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("c716fce7-6e12-49e0-87e1-d08104bb3dc0"), "You change the staff-storing shield from its shield form into the stored staff, which has an image of the shield on it, or change it from the stored staff back into a shield.");
                            });
                    })
                    .Build()
            };


            yield return new ShieldVariant
            {
                Id = Guid.Parse("112ad7a7-1973-43eb-9fc2-ffc9aa346766"),
                Name = "Staff-Storing Shield (Greater)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 11,
                BrokenThreshold = 27,
                Hardness = 9,
                HitPoints = 54,
                Price = 130000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("aa5c9175-a7c1-4d9f-8e6c-6f8804700d3b"), "The shield has Hardness 9, HP 54, and BT 27.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3720e7b8-f837-413b-b7af-2703b933bee4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("2477892c-84f5-45d6-9925-b269568b4c10"), "You change the staff-storing shield from its shield form into the stored staff, which has an image of the shield on it, or change it from the stored staff back into a shield.");
                            });
                    })
                    .Build()
            };


            yield return new ShieldVariant
            {
                Id = Guid.Parse("97dd807a-8ea9-4f87-969a-6ab3ab327db2"),
                Name = "Staff-Storing Shield (Major)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 15,
                BrokenThreshold = 36,
                Hardness = 12,
                HitPoints = 72,
                Price = 550000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f687c61e-28f3-4051-8909-d3e9bcd28cdf"), "The shield has Hardness 12, HP 72, and BT 36.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6c5d00d0-addc-40f3-8031-5483764f7f6e"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("2240981c-a5da-48a7-975d-ca3e524a99a1"), "You change the staff-storing shield from its shield form into the stored staff, which has an image of the shield on it, or change it from the stored staff back into a shield.");
                            });
                    })
                    .Build()
            };


            yield return new ShieldVariant
            {
                Id = Guid.Parse("4023c44a-2b82-44e6-9480-5bc02d24ff45"),
                Name = "Staff-Storing Shield (True)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 20,
                BrokenThreshold = 48,
                Hardness = 16,
                HitPoints = 96,
                Price = 5500000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("53054ac9-c251-4920-96a9-638f91d0ff15"), "The shield has Hardness 16, HP 96, and BT 48.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4fb6cfff-db18-4923-b1d6-3c48deec2129"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("137d123f-b025-4409-9ffe-9d16c8cab7ea"), "You change the staff-storing shield from its shield form into the stored staff, which has an image of the shield on it, or change it from the stored staff back into a shield.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f09759c-b71b-4975-81a2-535331cccac8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 190
            };
        }
    }
}
