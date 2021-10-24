using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class DivineSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Divine Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your deity bestows on you the power to cast divine spells. You can cast divine spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a cleric, you can usually hold a divine focus (such as a religious symbol) for spells requiring material components instead of needing to use a material component pouch. At 1st level, you can prepare two 1st-level spells and five cantrips each morning from the common spells on the divine spell list in this book or from other divine spells to which you gain access. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a cleric, the number of spells you can prepare each day increases, as does the highest level of spell you can cast, as shown in Table 3–9: Cleric Spells per Day on page 120." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or your enemies to roll against your spell DC (typically by attempting a saving throw). Since your key ability is Wisdom, your spell attack rolls and spell DCs use your Wisdom modifier." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is always automatically heightened to half your level rounded up—this is usually equal to the highest level of cleric spell slot you have. For example, as a 1st-level cleric, your cantrips are 1st-level spells, and as a 5th-level cleric, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Divine.ID);

            //Cantrips.
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Regular spell slots.
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 1,  spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3,  spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5,  spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7,  spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9,  spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);

            //Divine font spell slots. These are prerequisited to be active only at their specific levels.
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 1,  spellSlotLevel: 1);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 2,  spellSlotLevel: 1);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 3,  spellSlotLevel: 2);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 4,  spellSlotLevel: 2);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 5,  spellSlotLevel: 3);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 6,  spellSlotLevel: 3);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 7,  spellSlotLevel: 4);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 8,  spellSlotLevel: 4);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 9,  spellSlotLevel: 5);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 10, spellSlotLevel: 5);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 11, spellSlotLevel: 6);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 12, spellSlotLevel: 6);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 13, spellSlotLevel: 7);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 14, spellSlotLevel: 7);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 15, spellSlotLevel: 8);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 16, spellSlotLevel: 8);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 17, spellSlotLevel: 9);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 18, spellSlotLevel: 9);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 19, spellSlotLevel: 10);
            builder.GainDivineFontSpellSlot(Guid.Parse(""), Guid.Parse(""), exactRequiredLevel: 20, spellSlotLevel: 10);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 118
            };
        }
    }
}
