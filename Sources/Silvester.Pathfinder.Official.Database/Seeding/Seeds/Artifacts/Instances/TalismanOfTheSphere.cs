using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class TalismanOfTheSphere : Template
    {
        public static readonly Guid ID = Guid.Parse("21c2c1f0-3464-4715-bb9b-6c826adab755");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Talisman of the Sphere",
                Destruction = "The talisman of the sphere is destroyed if touched by a sphere of annihilation.",
                Usage = "Held in 1 hand.",
                ItemLevel = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("29ee64e5-6151-4969-a9cb-1ecacb2916f9"), Type = TextBlockType.Text, Text = "This loop of adamantine can be slung on a chain to be worn as a necklace, but must be held to convey its benefits. A creature that can’t cast either arcane or occult spells takes 8d6 mental damage just from picking up the item, and they take that damage again at the start of each of their turns if they continue to hold it." };
            yield return new TextBlock { Id = Guid.Parse("bb31e579-64ca-49d3-8353-a7b80b5d4fde"), Type = TextBlockType.Text, Text = "If the wielder can cast arcane or occult spells, they can use the talisman of the sphere to more easily control a sphere of annihilation. This reduces the DC of the check to control the sphere or Sustain the Activation by 10." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ecfe34d-e3fe-4e8c-bfc7-e3a0dcdc119c"),
                SourceId = Sources.Instances.GamemasteryGuide.ID,
                Page = 113
            };
        }
    }
}
