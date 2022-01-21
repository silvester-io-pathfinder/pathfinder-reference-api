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
    public class LionsShield : Template
    {
        public static readonly Guid ID = Guid.Parse("db9a1fda-d1d6-4e15-a732-4acb0851f601");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Lion's Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("44f496a8-87d8-4007-87b6-a2f33079f966"), "This steel shield (Hardness 6, HP 36, BT 18) is forged into the shape of a roaring lion�s head. The lion�s head functions as +1 striking shield boss that can�t be removed from the shield.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e44c9d1b-25c8-417b-875e-d032203f581a"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("4ab6916a-2bbc-46e5-931f-9e0b0ec57134"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("6149e32a-fd2b-4efe-afe0-fbc6ebcfc0be"),
                Name = "Lion's Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                BrokenThreshold = 18,
                Hardness = 6,
                HitPoints = 36,
                Price = 24500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("636ad655-2888-4546-8c43-958b99195b1d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Raise a Shield")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("b7de9e83-bced-41ca-8b7c-39fd8e794f69"), "You animate the lion�s head. You Raise the Shield and make a melee Strike with it as part of the same action. The shield�s biting maw is a martial melee weapon that deals 2d6 piercing damage and has the deadly 1d6 trait; it can�t be enhanced by runes. The shield remains animated for 1 minute, during which time you can Strike with it each time you Raise the Shield, as well as with a Strike action.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b441730a-3fcd-4352-b69f-577fd7477b76"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 588
            };
        }
    }
}
