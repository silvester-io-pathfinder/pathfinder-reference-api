using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class WitchSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Witch Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Using your familiar as a conduit, your patron provides you the power to cast spells. You can cast spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level, you can prepare up to two 1st-level spells and five cantrips each morning from the spells your familiar knows. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a witch, your number of spell slots and the highest level of spells you can cast from spell slots increase, as shown in Table 2–7: Witch Spells per Day." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Intelligence, your spell attack rolls and spell DCs use your Intelligence modifier." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up—this is usually equal to the highest level of witch spell slot you have. For example, as a 1st-level witch, your cantrips are 1st-level spells, and as a 5th-level witch, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Spellcasting ability
            builder.GainSpellcastingAbility(Guid.Parse(""), Stats.Instances.Intelligence.ID);
            
            //Cantrips
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Spell slots.
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 1, spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3, spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5, spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7, spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9, spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
