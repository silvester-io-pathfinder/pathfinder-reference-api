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
    public class Serithtial : Template
    {
        public static readonly Guid ID = Guid.Parse("f52c155f-6264-405c-a860-ca23f4c1fa0c");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Serithtial",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("27cf28aa-6ebb-47ca-86c6-a81244952b4b"), "The legendary blade Serithtial is said to have been forged by Iomedae, goddess of honor, justice, and valor. She is an intelligent +4 major striking holy bastard sword. Although the sword is made of steel, Serithtial is also treated as cold iron and silver, allowing her to deal more damage to certain supernatural creatures. She glows as bright as a torch, but you or Serithtial can suppress or resume this glow as a single action, which has the concentrate trait. In addition, Strikes with Serithtial deal an additional 2d6 damage against creatures that are worshippers of Zon-Kuthon, and while wielding Serithtial, you constantly benefit from death ward and freedom of movement spells that function only against effects created by followers of Zon-Kuthon.");;
            builder.Text(Guid.Parse("4673df5f-7916-49ff-baba-3fd8846f5340"), "Serithtial was forged as a bastard sword, and she reverts to this shape when no one wields her, but she can also detect what sort of blade her current wielder prefers and transform into it (choosing from dagger, shortsword, longsword, scimitar, falchion, greatsword, rapier, or bastard sword) using an action, which she does when first held. The wielder can empathically tell Serithtial to transform at any time by using a single action, which has the concentrate trait, after which Serithtial uses an action to transform.");;
            builder.Text(Guid.Parse("82640fc0-235c-42b2-a213-98018b734bf1"), "Serithtial is willing to work with a partner of almost any alignment as long as they are dedicated to defeating the great wyrm Kazavon and the forces of Zon-Kuthon. If you ignore those threats and pursue your own agenda instead, before long Serithtial attempts to seize control of your body (DC 45 Will save to resist her control), though she typically remains in control for only long enough to find a more worthy partner. You can attempt a new Will save each day to retake control of your body.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("328884fd-0a78-44f2-a084-e0104ade6992"),
                Name = "Serithtial",
                Hands = 1,
                Destruction = "If Kazavon or a great wyrm shadow dragon who is a worshipper of Zon-Kuthon uses its breath weapon on Serithtial while she is unattended, the sword melts into a pool of mundane iron.",
                Level = 23,
                RarityId = Rarities.Instances.Unique.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                BulkId = Bulks.Instances.OneBulk.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bad32aba-a5a3-4d86-b11f-4be79bb2cad1"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Frequency("Once per hour.")
                            .Requirements("")
                            .Trigger("")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("00682ecb-0194-4558-a68f-971f6f3d8535"), "Serithtial spends the appropriate number of actions and casts a 9th level heal or zone of truth spell (DC 45 for either of the two spells).");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("19b79096-5124-4a19-a912-c871288d8fa7"), Traits.Instances.Unique.ID);
            builder.Add(Guid.Parse("cae994f0-3840-43d5-9ab3-3b594275815f"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("ab17fd46-76d9-4699-b76d-5ca074b8007b"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("4675564a-7a1c-457a-851a-f227542036d0"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("e2dbe9f6-b128-4ea0-abab-0ce9d2fa1d2d"), Traits.Instances.Intelligent.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("031e2460-4401-49cf-9086-737daa930941"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 112
            };
        }
    }
}
