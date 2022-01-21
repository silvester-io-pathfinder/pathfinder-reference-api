using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class AmamanthinePavise : Template
    {
        public static readonly Guid ID = Guid.Parse("136d92f2-81ca-4de5-8d77-47da77c4a17f");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Amamanthine Pavise",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1b1a7eba-ca17-407a-a2b8-8f3eed70dd27"), "This tower shield (Hardness 9, HP 54, BT 27) was developed by followers of Ketephys, the elven god of the hunt. It's distinct for having a central ridge, and for being made from only wood and hide. Ketephys's religious symbol, a hawk rising over a silver crescent, is painted on the hide stretched across the front of the shield. Each amaranthine pavise is blessed by Ketephysian priests to aid in liberating Tanglebriar and defeating the nascent demon lord Treerazer. While you have the shield raised, you gain a +2 circumstance bonus to saving throws against the innate spells and special abilities of demons. When your allies have cover from the amaranthine pavise, the circumstance bonus they gain from cover to Reflex saves against area effects also applies to Fortitude and Will saves against demons' area effects.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b5b6b1c1-45d5-42f1-abd7-bd972585901a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4699e438-3171-4f81-b8c9-75039a5c3de5"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("430ae50b-21c1-49e8-b7d5-0c97079895aa"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("3899bc61-356c-4a77-889c-e04e255118c3"),
                Name = "Amamanthine Pavise",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                BrokenThreshold = 27,
                Hardness = 9,
                HitPoints = 54,
                Price = 100000,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("296cf9f1-aff9-47a3-add5-e7bfa64ee452"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("01c1cb46-e8fc-4359-b37a-7efb29473761"), "Ketephys's wrath descends upon your foes. The shield casts good divine wrath with a DC of 27.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("967c40d1-0d52-485f-a088-5b9fb11db378"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 30
            };
        }
    }
}
