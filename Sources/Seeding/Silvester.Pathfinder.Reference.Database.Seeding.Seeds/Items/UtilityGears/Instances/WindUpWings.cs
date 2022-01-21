using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class WindUpWings : Template
    {
        public static readonly Guid ID = Guid.Parse("14fc0bd9-bbde-4293-a8f1-06316059c32d");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Wind-Up Wings",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a0e81b77-ead5-49c4-9bde-a5d879c124db"), "These delicate clockwork wings enable thrown weapons to soar through the air at high speeds, performing turns and other aerial maneuvers midflight. Wind-up wings also have different types of special effects depending on the type. Wind-up wings must be attached to a thrown weapon and wound to function. A thrown weapon with an attached set of wind-up wings can�t have anything else attached to it, or the wings cease to function.");
            builder.Text(Guid.Parse("16513bd0-c381-4329-868f-a1e24d108417"), "Attaching or detaching a pair of wind-up wings to a thrown weapon requires a repair kit, and the process takes 10 minutes. Winding an attached pair of wind-up wings takes three Interact actions. There are a variety of wind-up wings, with different effects.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("781880d4-c4cc-434e-9b80-4990a8b0dfd8"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("c2fbc4f7-0146-4d3e-b5ab-174d594765fa"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2727dafd-d1e8-4cdd-9eb2-f304946c9621"),
                Name = "Flutterback Wind-Up Wings",
                Usage = "Attached to a thrown weapon.",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("11420304-f34d-430a-a236-a1628ae8a2c4"), "When you make a thrown Strike with the weapon to which a pair of flutterback wind-up wings are attached, and the wings are wound, the wings fly the weapon back to your hand after the Strike is complete. If your hands are full when the weapon returns, the wings hover in place three feet above the ground. At the end of your turn, the wings are wound down; they don�t function again until wound. If you aren�t holding the weapon when the flutterback wind-up wings become wound down, the weapon falls to the ground.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("99c929b7-7aac-4400-975b-233132a8cf3d"),
                Name = "Homing Wind-Up Wings",
                Usage = "Attached to a thrown weapon.",
                Level = 12,
                Price = 180000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("51b541b2-1f46-4b0a-ba23-b30b348cc9a6"), "When you make a thrown Strike with the weapon to which a pair of homing wind-up wings are attached, and the wings are wound, the wings seek out your target, flying through cover and avoiding obstacles. You ignore the target�s concealed condition and reduce the target�s cover by one step (lesser cover to no cover, standard cover to lesser cover, or greater cover to standard cover). After the Strike is complete, the wings are wound down; they don�t function again until wound.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77229c66-58f3-4467-87ac-7811dcefaf3d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 65
            };
        }
    }
}
