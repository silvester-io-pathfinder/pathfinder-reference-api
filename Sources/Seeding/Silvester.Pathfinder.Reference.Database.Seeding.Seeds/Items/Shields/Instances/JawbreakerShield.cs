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
    public class JawbreakerShield : Template
    {
        public static readonly Guid ID = Guid.Parse("e85a62f1-66fb-4294-a64e-f832e6ae4ae6");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Jawbreaker Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("79a2ddda-b640-464b-b6d6-eade9f3b437d"), "This heavy bone shield is composed of a massive plate of dinosaur bone with jagged, tooth-like ridges ringing its edge. It has Hardness 12, HP 48, and BT 24. The ridges are unremovable +1 striking shield spikes that deal slashing damage instead of piercing damage. While holding the jawbreaker shield, you gain a +3 item bonus to your Reflex DC to resist Swallow Whole attacks.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0f36a0ee-4daa-4fe0-8483-a91b66507930"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("3c8fbab6-4bbb-427a-8e57-edb9d83c47ae"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("224556fe-4162-4992-935f-b4ae32cef882"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("5be189ed-4f6a-4b90-b2a1-3198cd1b4cbe"),
                Name = "Jawbreaker Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 12,
                BrokenThreshold = 24,
                Hardness = 12,
                HitPoints = 48,
                Price = 165000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0c8ce8ff-c628-4789-8ede-7218250141f5"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Trigger("A creature attacks you with a jaws or fangs Strike or similar Strike using its mouth.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("31eba91c-f1c4-40a7-85c9-8899faa54749"), "You make a shield bash Strike as a reaction against the attacker. If the shield bash hits, the target takes damage and must attempt a DC 31 Fortitude saving throw. The effects of the saving throw are determined after the effects of the triggering Strike are resolved.");
                            })
                            .RollableEffect(Guid.Parse("1bf070a2-88dc-47d3-ba7f-fcfb57ff92ba"), effect =>
                            {
                                effect
                                    .Success("The target is unaffected.")
                                    .Failure("You wound the target's mouth. It takes 1d6 persistent bleed damage and takes a -2 status penalty to attack and damage rolls with jaws, fangs, or similar Strikes for 24 hours.")
                                    .CriticalFailure("You break the target's jaw. As failure, and the creature can't make Strikes using its mouth for 1 minute. At the end of its turn, it can attempt a Fortitude save to regain the ability to make Strikes using its mouth.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("299b47c5-f46c-40c5-9842-e536860f65cc"),
                SourceId = Sources.Instances.Pathfinder154.ID,
                Page = 75
            };
        }
    }
}
