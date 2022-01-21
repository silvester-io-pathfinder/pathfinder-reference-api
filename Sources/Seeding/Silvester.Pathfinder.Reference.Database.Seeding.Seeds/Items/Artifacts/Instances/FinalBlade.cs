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
    public class FinalBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("102f0cfa-a922-428b-b340-713c25efa512");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Final Blade",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4cb9737c-fb0a-486b-b3db-2583751a5cc4"), "A Large or smaller restrained or willing creature can be executed by a final blade. As an artifact, a final blade cannot be harmed by any but a very specific means.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("cc422259-cbde-4a5d-8277-762777761bfe"),
                Name = "Final Blade",
                Level = 20,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.FortyBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("79fab3e8-5c85-48b2-8597-9487f2cd2c60"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact (1 minute)")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("b19c23a3-c7ef-4675-a962-33ea95e0e9dd"), "You execute a creature restrained beneath the blade. The executed creature takes 11d10 slashing damage and must succeed at a DC 45 Fortitude save or be decapitated as though it suffered a critical hit with a natural 20 from a +3 major striking vorpal scythe. The soul of a creature executed with a final blade is trapped, and the creature can't be returned to life through any means, even a miracle or similar magic. A final blade can hold any number of souls in this way, and they can be released only through a complex ritual known only to the Gray Gardeners or through the destruction of the final blade.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2a6599b4-88a3-428a-b896-e5bcd1c869e4"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("e5c06c93-cc7f-44aa-af3d-94d86409352b"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("4a4c3591-836a-43fa-93d7-e6cb144f3208"), Traits.Instances.Death.ID);
            builder.Add(Guid.Parse("6ea928d8-d060-4b51-ae11-4f48c46b1be7"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("f4bd3ca8-92b7-4467-9c76-34cc8dbc9236"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("46be46ed-3d22-4ebd-98ee-0600132825c2"), Traits.Instances.Occult.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca046546-099a-4e1f-addf-e98a7a2461fe"),
                SourceId = Sources.Instances.WorldGuide.ID,
                Page = 126
            };
        }
    }
}
