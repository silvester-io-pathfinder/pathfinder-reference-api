using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class RadiantSpark : Template
    {
        public static readonly Guid ID = Guid.Parse("331edf40-1407-4108-8dce-317d8b137902");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Radiant Spark",
                Destruction = "An archfiend or evil demigod must willingly swap their essence with that of a celestial dominated or bound by the artifact, then critically fail the saving throw against having their essence consumed. This permanently destroys both the artifact and the fiend or demigod.",
                Usage = "Held in 1 hand.",
                ItemLevel = 25,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9b5cfe93-7dd0-42a1-bc69-bb62d636588a"), Type = TextBlockType.Text, Text = "This shining prism is bound within a golden frame. The bright glow within the artifact is the gleaming essence of celestials bound within it in ancient times. Each activation consumes a bit of this celestial energy, projecting the screams of the celestials into your mind. While holding the Radiant Spark, you gain a +2 item bonus to saving throws against divine spells and effects and you are aware of its powers. If you are good, while holding the Radiant Spark, you are sickened 3 and can't recover from this condition." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("ce29489a-c373-4f35-b5df-1fe3b9bb3774"),
                Name = "Envision, Interact",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("aa6ccf33-9b97-4bc4-ad56-1f8cc5654f7f"), Type = TextBlockType.Text, Text = "The Radiant Spark casts a 10th-level dominate spell (DC 49) on a creature that isn't from the Material Plane. Celestials get an outcome one degree of success worse than the result of their save." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("1a7967cb-e6c0-47ae-8b34-5744cee8c1ec"),
                Name = "Envision",
                Trigger = "You begin casting a planar binding ritual",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("6585b523-d5e3-41a9-80fb-c69d8fb5a076"), Type = TextBlockType.Text, Text = "The Radiant Spark reduces the casting time of the ritual to 1 hour, and you don't need secondary casters for this ritual." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("3ea00a55-9847-4305-b64f-0213e3b41698"),
                Name = "Envision, Interact",
                Trigger = "The target critically fails their save against the Radiant Spark's dominate spell or you critically succeed at binding the target with the planar binding ritual using the artifact.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("15e7587a-9b92-4152-8746-ef592e6342a7"), Type = TextBlockType.Text, Text = "The target must attempt a DC 49 Will save and is immune to further attempts for 24 hours." }
                },
                RollableEffect = new RollableEffect {
                    Id = Guid.Parse("3cc0c624-61bf-468d-bebb-0e34aba28189"),
                    CriticalSuccess = "The target is unaffected.",
                    Success = "The target is drained 2.",
                    Failure = "The target dies and its essence is trapped within the Radiant Spark. It can be brought back to life only with powerful magic such as wish or miracle.",
                    CriticalFailure = "As failure, and the target can't be brought back to life until the Radiant Spark is destroyed."
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Occult.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70ebc439-4818-4acd-9cb2-9a036e16c7fd"),
                SourceId = Sources.Instances.Pathfinder162.ID,
                Page = 74
            };
        }
    }
}
