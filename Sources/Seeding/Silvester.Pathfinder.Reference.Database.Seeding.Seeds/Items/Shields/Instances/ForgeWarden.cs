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
    public class ForgeWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("a458dc68-23e7-455d-bb1c-fa5850076785");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Forge Warden",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4bac273c-0bbf-43e2-8032-c44e547944ec"), "The religious symbol of Torag, the forge god�an ornate hammer of dwarven construction�adorns the face of this reinforced steel shield (Hardness 10, HP 24, BT 12). The shield is a religious symbol of Torag.");
            builder.Text(Guid.Parse("015a1b34-3c94-4641-a2cd-d6a72711daca"), "You and any adjacent allies have fire resistance 5 while you have the shield raised. When used for a Shield Block, the forge warden rings out like the hammer strike of a blacksmith, and the symbol glows as if lit by the fires of a furnace.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("03ace924-f58e-4b89-a586-ddc9781fbd12"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7983bd44-dc04-43e2-af6c-018d2f271134"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("e6c98e4f-8fa0-45ff-81f5-7e4a15d445a5"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("834f3b89-b867-4f37-993c-d5b28ad7f35b"),
                Name = "Forge Warden",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                BrokenThreshold = 12,
                Hardness = 10,
                HitPoints = 24,
                Price = 97500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("7c4c857a-8b67-47c9-9c08-abf2b07459ca"), ActionTypes.Instances.FreeAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You use the forge warden to Shield Block an adjacent creature�s attack and the shield takes damage.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("82d57c71-0b5f-4de9-9532-be790568e6fb"), Traits.Instances.Fire.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("f65dc4af-cae6-4a08-9f3d-7e514c2c9f79"), "The attacking creature takes 2d6 fire damage.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92fed006-6e0c-48f9-83a4-baa66c6127ca"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 587
            };
        }
    }
}
