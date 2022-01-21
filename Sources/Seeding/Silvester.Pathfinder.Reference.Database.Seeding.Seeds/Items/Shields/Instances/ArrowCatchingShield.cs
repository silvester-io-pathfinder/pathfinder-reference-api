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
    public class ArrowCatchingShield : Template
    {
        public static readonly Guid ID = Guid.Parse("7733978a-e19f-41a3-b88d-f5d11cc5a19c");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Arrow-Catching Shield"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("604dcacb-5d7c-46e9-a94c-b08bb3f71b7f"), "This remarkable wooden shield (Hardness 10, HP 60, BT 30) is carved with images of overlapping fletched arrows.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("83320b01-3d66-4d17-aad3-47176faffb1c"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("36c43859-2bc9-414d-9fe0-4619f7124dde"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("84c46ed1-e68e-41bc-a7b0-05eca06dc0d5"),
                Name = "Arrow-Catching Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 11,
                BrokenThreshold = 30,
                Hardness = 10,
                HitPoints = 60,
                Price = 135000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7843a2ac-fb09-4339-a62f-f41f6b1593e4"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Trigger("A ranged weapon Strike targets a creature within 15 feet of you when you have this shield raised, and the attacker has not yet rolled their attack.")
                            .Frequency("Once per minute.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("572383c7-65f6-4e85-98ad-574f94329b18"), "The triggering Strike targets you instead of its normal target.If it hits, you gain the effects of the Shield Block reaction.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9881d20-8554-47a0-9b32-ae1924cec220"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
