using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MagicAmmunitions.Instances
{
    public class GhostAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("23a4ac41-906b-4e07-9e9f-841daf0466bf");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Ghost Ammunition",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7a842a5e-dd8b-4ae4-b4c0-c349169c8a65"), "Ghost ammunition is cool to the touch. This ammunition has the benefits of the ghost touch property rune and can fly through any obstacle except those that can block incorporeal creatures or effects. Though the ammunition penetrates barriers and ignores all cover, the target still benefits from the flat check from being concealed or hidden. You still can�t target an undetected creature without guessing.");
            builder.Text(Guid.Parse("5c4234c4-a44c-48c1-bf1a-cfc041b97d9c"), "After it is launched, the ammunition vanishes into mist. However, in the dead of the night 1d4 days later, it reappears in the last quiver or other container it was taken from.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("82f4c0e0-f27d-4565-afbd-580f456138c1"),
                Name = "Ghost Ammunition",
                Level = 14,
                Price = 90000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2d6613ab-1676-4999-be09-70360be0d826"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d302aa99-c82b-4806-85f3-517ff9d0aa12"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe83749b-8996-4a2e-8ec9-21dc64424237"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 559
            };
        }
    }
}
