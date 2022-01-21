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
    public class CursebreakBulwark : Template
    {
        public static readonly Guid ID = Guid.Parse("9fbdfb83-3e59-4cb2-ab22-05be8215a139");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Cursebreak Bulwark",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("837adb2e-0b38-465e-8e99-9a121134acb2"), "This tower shield (Hardness 14, HP 56, BT 28) is composed of interlocking hexagonal wooden tiles lined with metal. The tiles are painted a verdant green, and each is marked with a faded rune that protects against curses. While you have this shield raised, you gain a +1 circumstance bonus to saving throws against spells that target you, increasing to a +2 circumstance bonus against curses. You can unleash the energy stored in the shield to destroy a curse before it can affect you.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8ae709bc-4abe-4de2-b506-fd8cb9c7b358"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4efc928d-d965-4ae0-8675-812f2e3635e8"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("9b5a8368-d755-4082-a908-9a34b4b20083"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("72c26acb-41d9-47d1-b5f4-35bf294590df"),
                Name = "Cursebreak Bulwark",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 17,
                BrokenThreshold = 28,
                Hardness = 14,
                HitPoints = 56,
                Price = 1450000,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("638f410d-056b-4375-9f8b-b0bc9654d1d1"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You are targeted with a curse spell.")
                            .Frequency("Once per day.")
                            .Requirements("The cursebreak bulwark is raised.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("0a3f8c9a-0c4d-4e8b-8784-d96d801a15de"), "You activate the shield's countermeasures. It casts 8th-level remove curse with a counteract modifier of +27 against the triggering curse.");
                            });
                    })
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05333de9-45f0-4a47-9d2d-20d5c812d22e"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 18
            };
        }
    }
}
