using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class BloodlineParagon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Bloodline Paragon", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have perfected the magic in your bloodline. Add two common 10th-level spells of your tradition to your repertoire. You gain a single 10th-level spell slot you can use to cast these spells, using sorcerer spellcasting. Unlike other spell slots, you don’t gain more 10th-level spells as you level up, and they can’t be used for abilities that let you cast spells without expending spell slots or abilities that give you more spell slots. You can take the Bloodline Perfection sorcerer feat to gain a second slot." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySpell(Guid.Parse(""), spellLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
