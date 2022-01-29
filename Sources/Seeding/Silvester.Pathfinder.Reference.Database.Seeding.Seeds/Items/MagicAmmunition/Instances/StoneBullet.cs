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
    public class StoneBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("8a0b288d-1b3c-4503-9638-2c78cbd50326");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Stone Bullet",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("904bc27b-b7b0-4302-adef-4623eef9b4cb"), "This sling bullet looks like a petrified serpent's eye. A creature hit by an activated stone bullet is subject to the effects of a 6th-level flesh to stone spell (DC 34).");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("23490a62-fae0-4c0b-8a95-ebce1c338eb5"),
                Name = "Stone Bullet",
                Level = 15,
                Price = 130000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b3ed41b7-cca9-4fc5-bca7-db91dda14a5e"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ef7f4d06-9151-4265-a494-50ae911f3fff"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("f49e3ece-d454-4409-b077-172daaf94142"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("74014e7a-caf2-4fa3-b543-184ab597b1b8"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.SlingBullets.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47341593-6db1-431f-9735-bea3764b1035"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 560
            };
        }
    }
}
