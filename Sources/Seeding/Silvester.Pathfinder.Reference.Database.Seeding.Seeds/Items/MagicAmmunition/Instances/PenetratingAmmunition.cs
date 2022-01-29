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
    public class PenetratingAmmunition : Template
    {
        public static readonly Guid ID = Guid.Parse("f75639c1-5e14-439d-9707-89c87ece1bdb");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Penetrating Ammunition",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f81e993a-3bf0-44e9-9851-fef236025c99"), "This ammunition has a slender shape and a viciously pointed tip. When you activate and shoot penetrating ammunition, the Strike takes the shape of a 60-foot line originating from you. Roll one attack roll and compare the result to the AC of each target in the line. The ammunition ignores up to 10 of a target's resistance, and it can penetrate walls up to 1 foot thick with Hardness 10 or less. Each target that takes damage from this ammunition also takes 1d6 persistent bleed damage.");
            builder.Text(Guid.Parse("497928ed-0cb3-48c1-bc42-001cc5626ad1"), "If your attack roll result is a natural 20, you improve your degree of success only against the first target in the line, but you can still score a critical hit on other targets if your result exceeds their AC by 10 or more. If you have access to your bow's critical specialization effect, penetrating ammunition applies that effect only against a target in the last square of the line.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("4e5df9a2-6469-4bb8-8232-013ed909ca14"),
                Name = "Penetrating Ammunition",
                Level = 12,
                Price = 40000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("04a85116-db51-451e-949c-4d3f73f81403"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Interact");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("1f106b94-65e6-4e05-8090-d191d80648e9"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("cb2ff29e-f65c-4795-afea-1be22cde4cac"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("4f667ead-d52b-4b5c-90bf-dfdd6b0cdcee"), Traits.Instances.Transmutation.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Arrows.ID;
            yield return Ammunitions.Instances.Bolts.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f5784d9-de5b-4564-b324-852cc9093178"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 560
            };
        }
    }
}
