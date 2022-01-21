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
    public class SpellguardShield : Template
    {
        public static readonly Guid ID = Guid.Parse("63ad1253-7b90-435a-89b7-0d6fa9aa138f");
        
        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID, 
                Name = "Spellguard Shield",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7ebc047a-f92f-4232-8966-57d804a454b4"), "This shield bears eldritch glyphs to guard against magic. While you have this steel shield (Hardness 6, HP 24, BT 12) raised, you gain its circumstance bonus to saving throws against spells that target you (as well as to AC).");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c9ed23a4-b532-4dcf-9268-ef1b57347fe6"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("680f0563-089d-463d-bcfd-2a1904728947"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("af4dcb86-4c16-4fde-ae88-8e04e2d4fa2d"),
                Name = "Spellguard Shield",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                BrokenThreshold = 12,
                Hardness = 6,
                HitPoints = 24,
                Price = 25000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08fe5192-a4c6-4b68-ac2c-95e18d348261"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 588
            };
        }
    }
}
