using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts.Instances
{
    public class ArodensHearthstone : Template
    {
        public static readonly Guid ID = Guid.Parse("824c96fe-298c-42c3-96f1-2c95728079bc");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Aroden's Hearthstone",
            };
        }


        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2e74da34-f6f2-4736-a7cc-b7ad4ba2c983"), "This coin-sized gemstone can be used on its own but must be included in the construction of a hearth in order to fully activate its magic.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("6d50b01c-e5e2-4b60-9bda-5974501ce013"),
                Name = "Aroden's Heartstone",
                Destruction = "Using Aroden's Hearthstone to craft a cursed item results in a failed creation and causes the gemstone to split into five equal-sized but magically impotent pieces. Over the course of a year, four of theses pieces crumble to dust, while the fifth expands to the size of the original artifact and bears its powers anew. To destroy Aroden's Hearthstone, each of the separated pieces must be plunged into one of the five stars that compose the cosmic constellation known as the Follower.",
                CraftingRequirements = "",
                Level = 25,
                Hands = 1,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("26a07a06-6274-4f90-bd22-107e088649ab"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("3 days (Interact)")
                            .Requirements("You have Legendary proficiency in Crafting.")
                            .Frequency("Four times per year.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("b42fcb22-569c-4f33-ac51-d6cfaea154e5"), "You craft a magical weapon or armor of up to 20th level. You must attempt a Crafting check as usual to create the item, but you need supply only raw materials worth a quarter of the item's Price, and you need not pay the remaining portion of the item's Price or spend additional downtime days working on it. While Aroden's Hearthstone is active, the stars in the sky, including Golarion's sun, appear to glow brighter within a 100-mile radius of the hearthstone.");
                            });
                    })
                    .Add(Guid.Parse("e8ea0b0e-8827-4ab0-a3a2-e92239009f4e"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision")
                            .Requirements("You have Legendary proficiency in Crafting.")
                            .Frequency("Once per month.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e655417e-dd66-41c6-9eab-78ccc685535b"), "Aroden's Hearthstone draws in heat from the world itself, causing the ambient temperature within 100 miles to drop below 0°F. Within 1 mile of the Hearthstone, the temperature drops to –200°F, rivaling the frigid cold of outer space and dealing 4d6 cold damage each round to every creature in the area. This effect lasts 1 minute, during which time the nearest moon (probably Golarion's) appears an eerie blue color to any observers within 100 miles of the hearthstone. At the end of 1 minute, the hearthstone emits a blast of concentrated heat that deals 25d6 fire damage to creatures and objects within 150 feet.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d083cafe-790e-4474-a8ce-d4491cedd434"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("4b23e3bc-54a2-4fd2-80af-256cc8a5c0eb"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("d31f8e05-7ce7-44ec-b634-9c350512f7e7"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("371619fe-718c-4c72-8f46-671b768ceb23"), Traits.Instances.Enchantment.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64abd9db-65fc-4f8d-aa52-d35c20b0cb3a"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 66
            };
        }
    }
}
