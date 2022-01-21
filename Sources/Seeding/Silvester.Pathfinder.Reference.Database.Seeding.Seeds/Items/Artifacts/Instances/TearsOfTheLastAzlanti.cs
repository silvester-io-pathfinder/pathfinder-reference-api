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
    public class TearsOfTheLastAzlanti : Template
    {
        public static readonly Guid ID = Guid.Parse("e18f640a-b8dc-42d2-8a31-15b2b31e6082");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Tears of the Last Azlanti",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("06e94be7-eb11-4b79-853b-f2853628e951"), "This gold necklace sports six bails, each with a different aeon stone. The backside of each bail is engraved with a single ancient Azlanti rune: Patience, Remembrance, Resilience, Tenacity, Wisdom, Invention.");;
            builder.Text(Guid.Parse("b30711b0-b616-4073-a826-7fd886735ebb"), "While a bail is active, you recall pieces of childhood memories, brief stories and lessons spoken to you by Aroden. The knowledge imparted by each bail carries a specific power but also allows you to access the invested and resonant powers of the aeon stone in the active bail's slot as though the stone orbited your head. Each day at dawn, a new bail becomes active; roll 1d6 to determine which bail is active, determined by the table below. Only one bail can be active at any time.");;
           
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("bcb815de-47e2-41b7-bee8-e98aea18656c"),
                Name = "Tears of the Last Azlanti",
                Usage = "Worn necklace.",
                Destruction = "The memories and lessons that echo through the Tears of the Last Azlanti give clues about steps needed to destroy the artifact. After you have gained the power of each of the six aeon stones at least once, you are granted visions of six locations across Golarion. At each of these locations, you must replace one of the necklace's aeon stones with a dull gray aeon stone. Once the final stone is replaced, the powers of the necklace are drawn into its new stones. These stones become pieces of throneglass, and the chain and bails disintegrate.",
                Level = 25,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e19334ab-c334-4e55-82a4-38a5c3fe93c2"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Manipulate")
                           .Frequency("Once per day.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("a6ed4e2f-1f38-4528-a041-00604b98d9d2"), "Once per day, you can attempt to exchange the aeon stone in a given bail for another aeon stone with a successful DC 35 Arcana check."); ;
                               effect.Heading(Guid.Parse("004c6bf1-53e1-4ded-baea-5d25d2d035b8"), "1 - Patience - Gold Nodule"); ;
                               effect.Text(Guid.Parse("03d6a790-e939-4e54-b8b5-47fa7bb37e16"), "Active Power: Telepathy with a range of 100 feet."); ;
                               effect.Heading(Guid.Parse("d0b46ed6-b4e3-43dc-84b6-540404d2be0b"), "2 - Remembrance - Tourmaline Sphere"); ;
                               effect.Text(Guid.Parse("9276c353-5fab-46da-b1bd-4aba3d42b668"), "Active Power: Cast hypercognition at will."); ;
                               effect.Heading(Guid.Parse("19d49425-1575-403b-9b66-ac0c216116bd"), "3 - Resillience - Clear Spindle"); ;
                               effect.Text(Guid.Parse("e527d499-a44d-4525-a3fe-05fa34d5b4bb"), "Active Power: Worn armor gains the antimagic property rune."); ;
                               effect.Heading(Guid.Parse("ef1730fe-0a53-45fc-b05e-1fd58b322ebd"), "4 - Tenacity - Pink Rhomboid"); ;
                               effect.Text(Guid.Parse("b9c581cf-1675-4e79-9462-9124a9411acd"), "Active Power: Wielded weapons gain the vorpal property rune."); ;
                               effect.Heading(Guid.Parse("b9a020ed-856c-4dfa-ac67-63fe48b2fa20"), "5 - Wisdom - Orange Prism"); ;
                               effect.Text(Guid.Parse("9d6f43f2-8b54-4098-9a2f-c5710fcffbd2"), "Active Power: SKill checks for downtime activities or to Recall Knowledge are one degree of success higher."); ;
                               effect.Heading(Guid.Parse("fa58cbc0-ac62-47c4-a059-4849a4bf2caa"), "6 - Invention - Lavender and Green Ellipsoid"); ;
                               effect.Text(Guid.Parse("daf80aec-92da-40cb-8e51-2045bf1220c8"), "Active Power: You can craft items up to 5 levels higher than your actual level."); ;
                           });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3467eeb0-8f73-420b-9fbf-47e7aa49da50"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("2a535a78-5389-4b05-ad7f-304c14323fb2"), Traits.Instances.Arcane.ID);
            builder.Add(Guid.Parse("bea024e2-4e60-40eb-8d16-4c7fdcd24cc8"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("579b39c5-5692-462e-9bf5-028b31dfbc45"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("4822f535-9c02-470b-814b-626da5243365"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62d933e1-eaeb-42f7-aa5a-0d33584a234d"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 69
            };
        }
    }
}
