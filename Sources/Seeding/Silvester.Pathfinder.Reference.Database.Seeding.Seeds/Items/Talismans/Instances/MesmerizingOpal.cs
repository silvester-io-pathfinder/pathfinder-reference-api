using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Talismans.Instances
{
    public class MesmerizingOpal : Template
    {
        public static readonly Guid ID = Guid.Parse("32320219-e50f-4379-a82a-289f2c1f5e30");

        protected override Talisman GetTalisman()
        {
            return new Talisman
            {
                Id = ID,
                Name = "Mesmerizing Opal",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("b4e24f28-2654-4568-8b49-0dd4d22bdd3c"), "This silver-bound opal pendant is afire with iridescence. When you activate it, if the outcome of your triggering Deception check is a critical failure, you get a failure instead (or if the outcome is a success, you get a critical success instead).");
        }

        protected override IEnumerable<TalismanVariant> GetTalismanVariants()
        {
            yield return new TalismanVariant
            {
                Id = Guid.Parse("49165e10-173a-49fe-b599-de9b0ef8b7bc"),
                Name = "Mesmerizing Opal",
                Usage = "Affixed to armor.",
                Level = 2,
                Price = 700,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4b9f7489-cfe8-4519-b506-dc9d014ca352"), ActionTypes.Instances.FreeAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You attempt a Deception check to Feint, but you haven't rolled yet.");
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b4a3a3e5-4a97-42a4-8ffa-1fddc6faae5a"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("a4bfe3f3-319c-48aa-a705-f97e23d044e1"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("913c10b4-af4c-47f1-a708-c2e51662dfa4"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("90e9f097-a8e9-4a7e-825f-27541a790018"), Traits.Instances.Talisman.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4acb52af-eb69-4ee2-8d53-193c127deba6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 568
            };
        }
    }
}
