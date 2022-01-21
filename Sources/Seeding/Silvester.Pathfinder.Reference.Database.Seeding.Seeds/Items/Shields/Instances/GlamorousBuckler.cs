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
    public class GlamorousBuckler : Template
    {
        public static readonly Guid ID = Guid.Parse("8035abd3-61f1-4529-9f00-d32654a45252");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Glamorous Buckler",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d7e81368-8411-4409-bfff-669a326dd8ce"), "A glamorous buckler (Hardness 3, HP 6, BT 3) is lavishly decorated with gilding and inset gemstones that glitter in the light. While you have it raised, the glamorous buckler grants you a +1 item bonus to Deception checks to Feint.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ed6faddb-2716-4dab-ab5a-7362b22ece2a"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("b594bf9e-d306-4a6d-bee5-24b5d70130cf"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("c1d17b9c-7a27-497c-a0bc-880637fe3a25"),
                Name = "Glamorous Buckler",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 2,
                BrokenThreshold = 3,
                Hardness = 3,
                HitPoints = 6,
                Price = 3500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2750b8a9-2976-429d-9d8c-5208d4ac4687"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("You Feint.")
                            .Frequency("Once per day.")
                            .Requirements("You have the Glamorous Buckler raised.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("d86de633-8d3b-41ac-b8d2-4c1af5811e29"), "As you Feint, the glamorous buckler sparkles mightily. On a successful Feint, the target is dazzled for 1 round.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0be598d1-21b8-48ad-871b-7ef48603d6e8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 261
            };
        }
    }
}
