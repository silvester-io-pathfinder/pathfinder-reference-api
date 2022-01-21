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
    public class ElderSign : Template
    {
        public static readonly Guid ID = Guid.Parse("891ae18b-dc47-4426-9148-8aa4669ad0c7");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Elder Sign",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("06dc3b48-0a47-4205-b8cf-ca57d93219d2"), "This stone tablet is carved with the symbol of a five-branched twig. There are only a limited number of elder signs, and each time one is destroyed, the universe's doom creeps inexorably closer. Reciting one of three different occult mantras (DC 20 Occultism check to do so correctly) allows three different activations. All three abilities work only on a creature connected to the Elder Mythos or a cosmic horror, such as a wendigo or gug; the activations refer to them as “eldritch creatures.”");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("69a56e80-0326-4961-aba3-fb84fd1d6dbc"),
                Name = "Elder Sign",
                Destruction = "The only way to destroy an elder sign is to use it to banish a Great Old One.",
                CraftingRequirements = "",
                Level = 25,
                Hands = 1,
                RarityId = Rarities.Instances.Rare.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("21a00b42-f9bc-4482-9200-1158558dad95"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                     {
                         action
                            .Kind("Command, Envision, Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("650c5752-e8e3-4737-a190-1a37baebbfe8"), "The elder sign casts a 10th-level banishment spell on an eldritch creature. Even if the creature isn't extraplanar, the elder sign can still banish it, sending it back to the part of the Material Plane from which it originated. If the creature is a Great Old One, the elder sign banishes it automatically (as if it critically failed its save) but is then forever destroyed.");
                            });
                     })
                    .Add(Guid.Parse("3c4bcde6-3b6d-4066-8e5d-790cac0612f8"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("39c315bd-a1aa-411d-842a-1dbdab708f75"), "The elder sign casts dispel magic on an effect from an eldritch creature, using a counteract level of 10 and +30 modifier for the roll.");
                            });
                    })
                    .Add(Guid.Parse("1b990d52-6b74-430e-9630-1ae9005328c8"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Envision, Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("7cd71ff0-ec4e-4e77-9742-7c9235417d17"), "The elder sign casts dimensional lock, though it wards against travel by only eldritch creatures. Each time the elder sign casts dimensional lock in this way, the previous dimensional lock spell ends.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("39ab30b7-7b8f-40a8-a8cc-3770a0a6d047"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("f07d5d2f-e1ed-40b6-830c-bbaab46051b7"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("c3f89070-1d76-4a9a-8e25-862bd6bcf85b"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("dd873f32-15a2-413e-ba03-9cf544f76d5c"), Traits.Instances.Occult.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f73771fe-67ce-4d15-bedf-55db48c52f1e"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 108
            };
        }
    }
}
