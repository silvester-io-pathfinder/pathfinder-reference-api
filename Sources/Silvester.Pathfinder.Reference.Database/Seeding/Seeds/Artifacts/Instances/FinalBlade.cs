using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Artifacts.Instances
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
                ItemLevel = 20,
                BulkId = Bulks.Instances.FortyBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4cb9737c-fb0a-486b-b3db-2583751a5cc4"), Type = TextBlockType.Text, Text = "A Large or smaller restrained or willing creature can be executed by a final blade. As an artifact, a final blade cannot be harmed by any but a very specific means." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("79fab3e8-5c85-48b2-8597-9487f2cd2c60"),
                Name = "Interact",
                RequiredTime = "1 minute.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("b19c23a3-c7ef-4675-a962-33ea95e0e9dd"), Type = TextBlockType.Text, Text = "You execute a creature restrained beneath the blade. The executed creature takes 11d10 slashing damage and must succeed at a DC 45 Fortitude save or be decapitated as though it suffered a critical hit with a natural 20 from a +3 major striking vorpal scythe. The soul of a creature executed with a final blade is trapped, and the creature can’t be returned to life through any means, even a miracle or similar magic. A final blade can hold any number of souls in this way, and they can be released only through a complex ritual known only to the Gray Gardeners or through the destruction of the final blade." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Occult.ID;
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
