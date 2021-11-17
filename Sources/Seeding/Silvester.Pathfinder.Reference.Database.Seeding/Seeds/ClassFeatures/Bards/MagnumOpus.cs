using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class MagnumOpus : Template
    {
        public static readonly Guid ID = Guid.Parse("97c87c94-8ce2-4d7f-9770-d8e17601249d");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Magnum Opus", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("05afe27b-a283-45f5-8aa2-e8e443181580"), Type = TextBlockType.Text, Text = "You have tuned your spellcasting to the highest caliber. Add two common 10th-level occult spells to your repertoire. You gain a single 10th-level spell slot you can use to cast one of those two spells using bard spellcasting. You don�t gain more 10th-level spells as you level up, unlike other spell slots, and you can�t use 10th-level slots with abilities that give you more spell slots or that let you cast spells without expending spell slots." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("e91aa97f-0e9c-45d4-934e-85148dc18899"), MagicTraditions.Instances.Occult.ID, spellLevel: 10);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("f9fff4d6-61fe-4a55-af75-5b9b96663543"), MagicTraditions.Instances.Occult.ID, spellLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("794e941e-3705-4cc4-aa19-5a3a90cbe306"), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("379cb64b-8f87-43a6-9e3f-93ad34cdae10"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}