using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
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
                Destruction = "If Kazavon or a great wyrm shadow dragon who is a worshipper of Zon-Kuthon uses its breath weapon on Serithtial while she is unattended, the sword melts into a pool of mundane iron.",
                Usage = "Held in 1 hand.",
                ItemLevel = 23,
                BulkId = Bulks.Instances.OneBulk.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("27cf28aa-6ebb-47ca-86c6-a81244952b4b"), Type = TextBlockType.Text, Text = "The legendary blade Serithtial is said to have been forged by Iomedae, goddess of honor, justice, and valor. She is an intelligent +4 major striking holy bastard sword. Although the sword is made of steel, Serithtial is also treated as cold iron and silver, allowing her to deal more damage to certain supernatural creatures. She glows as bright as a torch, but you or Serithtial can suppress or resume this glow as a single action, which has the concentrate trait. In addition, Strikes with Serithtial deal an additional 2d6 damage against creatures that are worshippers of Zon-Kuthon, and while wielding Serithtial, you constantly benefit from death ward and freedom of movement spells that function only against effects created by followers of Zon-Kuthon." };
            yield return new TextBlock { Id = Guid.Parse("4673df5f-7916-49ff-baba-3fd8846f5340"), Type = TextBlockType.Text, Text = "Serithtial was forged as a bastard sword, and she reverts to this shape when no one wields her, but she can also detect what sort of blade her current wielder prefers and transform into it (choosing from dagger, shortsword, longsword, scimitar, falchion, greatsword, rapier, or bastard sword) using an action, which she does when first held. The wielder can empathically tell Serithtial to transform at any time by using a single action, which has the concentrate trait, after which Serithtial uses an action to transform." };
            yield return new TextBlock { Id = Guid.Parse("82640fc0-235c-42b2-a213-98018b734bf1"), Type = TextBlockType.Text, Text = "Serithtial is willing to work with a partner of almost any alignment as long as they are dedicated to defeating the great wyrm Kazavon and the forces of Zon-Kuthon. If you ignore those threats and pursue your own agenda instead, before long Serithtial attempts to seize control of your body (DC 45 Will save to resist her control), though she typically remains in control for only long enough to find a more worthy partner. You can attempt a new Will save each day to retake control of your body." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("bad32aba-a5a3-4d86-b11f-4be79bb2cad1"),
                Name = "Envision",
                Frequency = "Once per hour.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                Effects = new[] 
                {
                    new TextBlock { Id = Guid.Parse("00682ecb-0194-4558-a68f-971f6f3d8535"), Type = TextBlockType.Text, Text = "Serithtial spends the appropriate number of actions and casts a 9th level heal or zone of truth spell (DC 45 for either of the two spells)." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Divine.ID;
            yield return Traits.Instances.Intelligent.ID;
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
