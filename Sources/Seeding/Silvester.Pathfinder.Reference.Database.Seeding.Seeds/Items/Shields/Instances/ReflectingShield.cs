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
    public class ReflectingShield : Template
    {
        public static readonly Guid ID = Guid.Parse("e156ed6a-95ac-42e4-aec5-50b4ba1adea9");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Reflecting Shield",
              
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3667d7cd-4711-4a30-88dd-c82dfffeeefb"), "This high-grade silver buckler (Hardness 6, HP 24, BT 12) is polished to a mirrorlike sheen. The shield functions as a spellguard shield (see below) that can also reflect spells.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("6bce79be-68b2-4cbb-aa34-39311fa14c37"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("2d61fdde-9803-4536-93eb-f97f2a564230"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("f47557e3-6af1-44eb-9028-5040fcea492b"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("0147face-6e8e-46a9-99df-a9befaf917c4"),
                Name = "Reflecting Shield",
                CraftingRequirements = "Supply one casting of Spell Turning, and the initial raw materials must include at least 2,750 gp of silver.",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 18,
                BrokenThreshold = 12,
                Hardness = 6,
                HitPoints = 24,
                Price = 1800000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d8cbe269-c904-40f8-a498-659be7d31cd8"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You are targeted by any spell.")
                            .Frequency("Once per day.")
                            .Requirements("The Reflecting Shield is raised.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("fa2438b4-b801-4858-af65-8784e0731a84"), "You attempt to reflect the spell on its caster, with the effects of a 9th-level spell turning with a counteract modifier of +40.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbffb43a-cf3b-4624-8070-b4a7905c1126"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 588
            };
        }
    }
}
