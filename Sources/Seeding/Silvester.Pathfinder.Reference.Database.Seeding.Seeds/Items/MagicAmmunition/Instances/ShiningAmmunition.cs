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
    public class ShiningAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("0cefd701-8aa5-4800-a1ef-857ee7a1046a");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Shining Ammunition",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5dffed06-46a5-481d-989f-c7d0ba52c876"), "Shining ammunition gives off a faint glow. When shot, it sheds bright light in a 20-foot radius (and dim light to the next 20 feet) for 10 minutes. If it hits a target, it sticks, causing the target to shed light in the same radius. A creature can remove the ammunition with an Interact action, but the ammunition itself continues to glow for the rest of the duration or until destroyed.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("bb1cae02-25ea-46d6-b0f3-c253ae276541"),
                Name = "Shining Ammunition",
                Level = 1,
                Price = 300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5b5a2d62-70bf-4e04-aa35-7a2583f551bf"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("8519f3d2-5ba4-4c1e-809b-83e5dcf4eedb"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("b305a800-7030-41c7-b77d-5bb2a30e21ce"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("d0993475-180b-4576-9b5e-3ed1a452408a"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a611e3b-c6fa-4cb0-9faa-551a6fa3a20f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 560
            };
        }
    }
}
