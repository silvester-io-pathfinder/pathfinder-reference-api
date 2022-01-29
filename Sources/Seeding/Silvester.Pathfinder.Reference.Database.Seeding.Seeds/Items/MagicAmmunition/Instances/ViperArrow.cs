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
    public class ViperArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("a3a2b4f8-a0f2-471b-b629-2f240014e777");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Viper Arrow",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("42ae187c-387d-4a5d-b688-3574cb21fc35"), "The shaft of this arrow is covered in fine green scales, and its iron head comes to a pair of points almost like fangs. After an activated viper arrow hits a target, the arrow transforms into a viper (Pathfinder Bestiary 302). The target is affected by the viper's poison, as if it had been bitten. The viper then lands in an open space adjacent to the target.");
            builder.Text(Guid.Parse("e6b44aea-8877-40b6-8d3d-8183af11f99c"), "The viper has the summoned trait and acts at the end of your turn, even though you didn't use the Sustain a Spell action. It is under the GM's control, but it generally attacks the creature the arrow struck. The viper vanishes after 1 minute or when slain.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("6565362f-6714-478f-80ff-e653656773a7"),
                Name = "Viper Arrow",
                CraftingRequirements = "Supply one casting of summon animal.",
                Level = 4,
                Price = 1700,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9f927914-7fc3-4a35-acc8-b272426bb486"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action.Kind("Command");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2e49f1ec-6536-4db6-a6df-aea423c8ce4c"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("60235ca4-a878-427a-be9f-72e45ca5a03e"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("40184106-cd16-4990-a97f-efbaf76b0f71"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Arrows.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be7d499d-4521-4a49-9594-c082fcff1c9c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 561
            };
        }
    }
}
