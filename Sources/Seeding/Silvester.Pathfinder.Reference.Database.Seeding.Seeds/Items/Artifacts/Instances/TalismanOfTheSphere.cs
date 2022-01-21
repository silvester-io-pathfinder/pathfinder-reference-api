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
    public class TalismanOfTheSphere : Template
    {
        public static readonly Guid ID = Guid.Parse("21c2c1f0-3464-4715-bb9b-6c826adab755");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Talisman of the Sphere",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("29ee64e5-6151-4969-a9cb-1ecacb2916f9"), "This loop of adamantine can be slung on a chain to be worn as a necklace, but must be held to convey its benefits. A creature that can't cast either arcane or occult spells takes 8d6 mental damage just from picking up the item, and they take that damage again at the start of each of their turns if they continue to hold it.");;
            builder.Text(Guid.Parse("bb31e579-64ca-49d3-8353-a7b80b5d4fde"), "If the wielder can cast arcane or occult spells, they can use the talisman of the sphere to more easily control a sphere of annihilation. This reduces the DC of the check to control the sphere or Sustain the Activation by 10.");;
        }

        protected override IEnumerable<ArtifactVariant> GetArtifactVariants()
        {
            yield return new ArtifactVariant
            {
                Id = Guid.Parse("4cbc9bbe-c728-427f-a6a0-e1f6f8685f02"),
                Name = "Talisman of the Sphere",
                Usage = "Held in 1 hand.",
                Hands = 1,
                Destruction = "The talisman of the sphere is destroyed if touched by a sphere of annihilation.",
                Level = 20,
                RarityId = Rarities.Instances.Rare.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("67831831-15e4-46e8-b706-413fe8b67845"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("eac25acf-e28c-4f41-95af-ad3cae38204e"), Traits.Instances.Artifact.ID);
            builder.Add(Guid.Parse("ebbb59d5-6dcd-4498-b617-094d70f120b6"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("983892e5-bb61-4685-95c0-e2d937ce63e5"), Traits.Instances.Magical.ID);
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
