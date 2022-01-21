using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Serrating : Template
    {
        public static readonly Guid ID = Guid.Parse("9f59dddb-5e3b-4809-b14c-b2d31e002f50");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Serrating",
                AccessRequirements = "A character who is a member of the Knights of Lastwall has access to this option."
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6b4a120b-ff71-4b5f-9ba1-6addb0c7d3c1"), "A serrating weapon�s bladed edge separates into jagged, swirling shards that spin along the blade.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("8b4e3b95-e474-4a3c-bad9-62f53d7371be"),
                Name = "Serrating",
                Usage = "Etched onto a slashing melee weapon.",
                Level = 10,
                Price = 100000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("3d0b5a29-2e4e-4e8e-b16a-123d6c947bb9"), "When dealing slashing damage, the weapon deals an additional 1d4 damage.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3666ba96-6258-4345-a537-bc063b6eed08"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("f615ffc2-56fa-42ac-97f4-1303e9299b80"), "You brandish the weapon and focus its power, causing the serrated shards to buzz as they spin at a dizzying speed. On your next hit with the weapon this turn that deals slashing damage, the serrating rune adds an additional 1d12 damage instead of the additional 1d4 damage, and then the shards return to their usual speed.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("becb801a-2415-449a-b0d3-04d1d1b31978"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("8c1056c7-e875-4021-90a7-f4abfa1fa47f"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("311a7111-a152-4e74-9cfc-c157b64ec06b"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 93
            };
        }
    }
}
