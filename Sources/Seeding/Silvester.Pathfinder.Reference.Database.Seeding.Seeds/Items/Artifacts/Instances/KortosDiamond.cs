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
    public class KortosDiamond : Template
    {
        public static readonly Guid ID = Guid.Parse("7ff9f558-f18c-49f6-be41-5d9ba4644c4c");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Kortos Diamond",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d834fca2-601c-492d-bedf-3c6a6c08495d"), "The hilt of this +3 major striking axiomatic spell-storing longsword is simple and elegant. The blade itself is made of throneglass—a clear, jewellike crafting material with a razor-sharp edge, capable of absorbing psychic magic and redirecting it at the wielder's enemies. Whenever the Kortos Diamond is in an area of dim or brighter light, it glows faintly, as if reflecting the light of a setting sun.");;
            builder.Text(Guid.Parse("34bd4d93-1d52-4106-ab56-cd88e6d95960"), "While wielding the Kortos Diamond, you gain a +2 item bonus on saving throws against mental effects. You can never harm yourself with the Kortos Diamond, even if confused.");;
            builder.Text(Guid.Parse("746ff687-b0a3-4719-aa1d-20886670e0d1"), "If you ever travel farther than 100 miles from the Isle of Kortos while in possession of the Kortos Diamond, the sword becomes impossibly heavy; you are encumbered as long as you carry the sword and remain outside of this area. If you relinquish the Kortos Diamond while away from Kortos, the sword gradually makes its way back to the isle over the course of a year.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {            
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("95ea98d3-6de3-4e56-87c4-27c54021a4f3"),
                Name = "Kortos Diamond",
                Destruction = "A deity who ascended to divinity via the Test of the Starstone can damage and destroy the Kortos Diamond as if it were not an artifact.",
                Hands = 1,
                Level = 22,
                RarityId = Rarities.Instances.Unique.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("134aec75-3c9d-44a0-9233-a91b377167b8"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Interact")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("58854733-4136-4e02-b1de-d2f9fad10a00"), "You attempt a melee Strike with the Kortos Diamond against a creature within reach. On a hit, you deal damage as normal and the target's mind is inflicted with a powerful disruptive energy. When the creature attempts to Cast a Spell, it must attempt a DC 44 Will save; on a failure, the spell fails and both the spell and the actions spent to cast it are lost. This effect lasts for up to 1 minute.");
                           });
                    })
                    .Add(Guid.Parse("01a25c9c-b250-42fd-8893-6132362f4487"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                           .Kind("Envision")
                           .Frequency("Once per round.")
                           .Trigger("You damage an aberration with the Kortos Diamond.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("fe84aa36-6102-491b-9dee-c7e7ec267699"), "You deal an additional 2d8 force damage to the struck creature.");
                           });
                    })
                    .Add(Guid.Parse("98bb490c-bf5b-4cd3-afa5-41b0f24b9a41"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                           .Kind("Command, Interact")
                           .Frequency("Once per day.")
                           .Details(effect =>
                           {
                               effect.Text(Guid.Parse("134ed8b1-cc9f-4c01-9a94-729fe4251ff0"), "You hold the Kortos Diamond aloft and proclaim your might in a booming voice. You cast overwhelming presence (DC 42).");
                           });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("06ade661-ee76-48f7-9875-87008e6e68f0"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("9b3e5ead-34a2-482d-8bb0-14d371992d55"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("c26f3a0f-98f3-409d-8597-a8e653076b2f"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("1d22149f-730f-4cb7-80f9-9bde781adc11"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4a68d82-5e8a-4f5b-ab29-b3a15d3ed532"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 68
            };
        }
    }
}
