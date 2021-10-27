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
    public class SorcererSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Sorcerer Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your bloodline provides you with incredible magical power. You can cast spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a sorcerer, you can usually replace material components with somatic components, so you don't need to use a material component pouch." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each day, you can cast up to three 1st-level spells. You must know spells to cast them, and you learn them via the spell repertoire class feature. The number of spells you can cast each day is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a sorcerer, your number of spells per day increases, as does the highest level of spells you can cast, as shown on Table 3–17: Sorcerer Spells per Day." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "ome of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Charisma, your spell attack rolls and spell DCs use your Charisma modifier." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level to match the spell slot. You must have a spell in your spell repertoire at the level you want to cast in order to heighten it to that level. Many spells have specific improvements when they are heightened to certain levels. The signature spells class feature lets you heighten certain spells freely." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up—this is usually equal to the highest level of sorcerer spell slot you have. For example, as a 1st-level sorcerer, your cantrips are 1st-level spells, and as a 5th-level sorcerer, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpellcastingAbility(Guid.Parse(""), Stats.Instances.Charisma.ID);

            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 1, spellSlotLevel: 1, amount: 3, increaseTo: 4, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3, spellSlotLevel: 2, amount: 3, increaseTo: 4, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5, spellSlotLevel: 3, amount: 3, increaseTo: 4, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7, spellSlotLevel: 4, amount: 3, increaseTo: 4, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9, spellSlotLevel: 5, amount: 3, increaseTo: 4, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11, spellSlotLevel: 6, amount: 3, increaseTo: 4, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13, spellSlotLevel: 7, amount: 3, increaseTo: 4, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15, spellSlotLevel: 8, amount: 3, increaseTo: 4, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17, spellSlotLevel: 9, amount: 3, increaseTo: 4, atLevel: 18);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 192
            };
        }
    }
}
