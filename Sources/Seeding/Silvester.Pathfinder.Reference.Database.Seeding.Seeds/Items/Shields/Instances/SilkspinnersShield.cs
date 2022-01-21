using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class SilkspinnersShield : Template
    {
        public static readonly Guid ID = Guid.Parse("2dfbcad1-5af8-44ba-93c3-76c7cdfd0b88");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Silkspinner's Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("aec7356f-7af7-4568-9d90-7899aa1de78f"), "This oddly fuzzy buckler (Hardness 10, HP 60, BT 30) resembles the abdomen of a spider. Its defensive side is covered in fine hairs, and two small spinnerets protrude from the bottom of its rim. The spinnerets serve as +2 greater striking shield spikes.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("32808993-f56d-4645-8daf-0f3852f60b5b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("615bddfc-5313-4346-ae90-0ecc6878b67c"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8a718129-7d1b-4cdd-a07a-f81d95d90c53"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("ffb87a15-680a-4dd6-832b-6cf67af45557"),
                Name = "Silkspinner's Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 15,
                BrokenThreshold = 30,
                Hardness = 10,
                HitPoints = 60,
                Price = 600000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f81a0d3f-a120-47e6-b29d-a9cbe7502917"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("b7c0ae6b-0680-44e3-a456-cdde4d9f51d8"), "You animate the silkspinner's shield. Eight spider legs sprout from the shield's rim, granting you a climb Speed of 25 feet until the end of your next turn. Additionally, the spinnerets animate and produce silk for 1 minute. Successful shield bash Strikes made with the silkspinner's shield during this time entangle the target in silk. The target takes a �10-foot circumstance penalty to its Speeds for 1 round. If your Strike was a critical hit, the target becomes immobilized for 1 round instead. Regardless, the target can attempt to Escape (DC 30) to end the effect early.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3eb2bec5-58d9-46eb-8c00-a30a8fcb385d"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 11
            };
        }
    }
}
