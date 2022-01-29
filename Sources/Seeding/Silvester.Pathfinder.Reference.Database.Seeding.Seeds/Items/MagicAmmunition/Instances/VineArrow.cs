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
    public class VineArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("4defdd27-6269-4e51-b08d-869dd3883bd2");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Vine Arrow",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6ebd8319-9831-424b-a8f7-985dcb51d862"), "Leafy stalks protrude from the shaft of this rustic arrow. When an activated vine arrow hits a target, the arrow's shaft splits and grows, wrapping the target in vines. The target takes a -10-foot circumstance penalty to its Speeds for 2d4 rounds, or until it Escapes against a DC of 19. On a critical hit, the target is also immobilized until it Escapes.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("855c097f-a0c2-405b-813c-acfcdc50ebac"),
                Name = "Vine Arrow",
                Level = 3,
                Price = 1000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0aeef2e9-d71d-44c7-8402-1eb9c6e98f2f"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Command");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f6230a66-051c-4b58-bb37-9f423a19a3fb"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("75f93aa1-8e8b-4c45-a66e-4139a6ad566f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("10e732df-52f3-47cf-ba27-d1cb06d870a0"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Arrows.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("615d630e-a980-4309-b662-33df02fa3215"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 560
            };
        }
    }
}
