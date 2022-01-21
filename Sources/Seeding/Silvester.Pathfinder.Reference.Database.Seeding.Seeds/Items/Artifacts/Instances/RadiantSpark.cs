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
    public class RadiantSpark : Template
    {
        public static readonly Guid ID = Guid.Parse("331edf40-1407-4108-8dce-317d8b137902");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Radiant Spark"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9b5cfe93-7dd0-42a1-bc69-bb62d636588a"), "This shining prism is bound within a golden frame. The bright glow within the artifact is the gleaming essence of celestials bound within it in ancient times. Each activation consumes a bit of this celestial energy, projecting the screams of the celestials into your mind. While holding the Radiant Spark, you gain a +2 item bonus to saving throws against divine spells and effects and you are aware of its powers. If you are good, while holding the Radiant Spark, you are sickened 3 and can't recover from this condition.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("b868e76c-7351-441e-a61a-ff33ffc44284"),
                Name = "Radiant Spark",
                Hands = 1,
                Destruction = "An archfiend or evil demigod must willingly swap their essence with that of a celestial dominated or bound by the artifact, then critically fail the saving throw against having their essence consumed. This permanently destroys both the artifact and the fiend or demigod.",
                Level = 25,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.LightBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ce29489a-c373-4f35-b5df-1fe3b9bb3774"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision, Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("aa6ccf33-9b97-4bc4-ad56-1f8cc5654f7f"), "The Radiant Spark casts a 10th-level dominate spell (DC 49) on a creature that isn't from the Material Plane. Celestials get an outcome one degree of success worse than the result of their save.");
                            });
                    })
                    .Add(Guid.Parse("1a7967cb-e6c0-47ae-8b34-5744cee8c1ec"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Envision")
                           .Frequency("")
                           .Requirements("")
                           .Trigger("You begin casting a planar binding ritual.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("6585b523-d5e3-41a9-80fb-c69d8fb5a076"), "The Radiant Spark reduces the casting time of the ritual to 1 hour, and you don't need secondary casters for this ritual.");
                           });
                    })
                    .Add(Guid.Parse("3ea00a55-9847-4305-b64f-0213e3b41698"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Envision, Interact")
                           .Trigger("The target critically fails their save against the Radiant Spark's dominate spell or you critically succeed at binding the target with the planar binding ritual using the artifact.")
                           .RollableEffect(Guid.Parse("3cc0c624-61bf-468d-bebb-0e34aba28189"), effect => 
                           {
                               effect.CriticalSuccess("The target is unaffected.");
                               effect.Success("The target is drained 2.");
                               effect.Failure("The target dies and its essence is trapped within the Radiant Spark. It can be brought back to life only with powerful magic such as wish or miracle.");
                               effect.CriticalFailure("As failure, and the target can't be brought back to life until the Radiant Spark is destroyed.");
                           })
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("15e7587a-9b92-4152-8746-ef592e6342a7"), "The target must attempt a DC 49 Will save and is immune to further attempts for 24 hours.");
                           });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("761a3410-003f-41cd-a561-6b7c7485071c"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("5a1bf7ca-cf2e-4c58-a51d-1cd3ea2b686d"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("7102e63c-8496-4420-8dd1-093b3dfb448b"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("15ae118c-cc42-423f-bc1c-1aa07b1df99f"), Traits.Instances.Occult.ID);
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
