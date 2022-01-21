using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes.Instances
{
    public class Ethereal : Template
    {
        public static readonly Guid ID = Guid.Parse("76e3db46-6f8a-4a56-9459-58d0b14e2059");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Ethereal",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("aa6891cb-39ce-4647-b7f9-c7252ab598a1"), "An ethereal rune replicates armor on the Ethereal Plane.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("7645428c-8707-496a-872a-42bc584b8717"),
                Name = "Ethereal",
                Usage = "Etched onto armor.",
                CraftingRequirements = "Supply a casting of 9th-level ethereal jaunt.",
                Level = 17,
                Price = 1350000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("13ef1f89-bd03-400e-960f-2cf2ffc951d5"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("3500e64f-8713-4118-b987-9cd9a5fc510a"), "You gain the effects of an ethereal jaunt spell. This doesn't require concentration and lasts for 10 minutes or until you choose to return to material form as a free action.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("524df439-5d06-465d-9e2a-6dc22a98592d"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("05ed9b28-56ae-4e31-8456-733c294f22e4"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1422800-1f08-4c43-99cd-c5819ade517c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
