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
    public class NethysianBulwark : Template
    {
        public static readonly Guid ID = Guid.Parse("d1bc28a4-9287-4d5f-b466-99405d3829bc");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Nethysian Bulwark",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("64b42713-4460-47a2-899e-3ee27e42dd6f"), "This round shield is often fashioned to resemble the religious symbol of its dual-natured namesake. A Nethysian bulwark is a high-grade cold iron shield (Hardness 10, HP 40, BT 20) that defends the wielder and can explode with retributive force when struck.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5badd560-6bde-4e57-a9d9-17521f167387"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c2983f41-0b79-4233-8474-3a5e4ae54977"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("aa12b1c7-e570-49c3-a8d8-faf436814293"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("e46f7578-931d-4e7b-b955-e8aeea85364a"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("bb46c9e3-3296-4468-94f8-0aa57f85d222"),
                Name = "Nethysian Bulwark",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 16,
                BrokenThreshold = 20,
                Hardness = 10,
                HitPoints = 40,
                Price = 800000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("594f5d75-a33b-4956-92a8-d1223303a0c9"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("The shield becomes broken when performing a Shield Block;")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("c3260fd4-98d5-4451-bfae-de5af8860760"), "The shield explodes in a burst of bright light and shadowy tendrils, releasing a 15-foot cone of force that must include the attacker if possible. The cone deals 6d8 force damage to all creatures in the area (DC 34 basic Reflex save).");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a529767-5268-48a6-bee1-697a9ef19883"),
                SourceId = Sources.Instances.Pathfinder149.ID,
                Page = 77
            };
        }
    }
}
