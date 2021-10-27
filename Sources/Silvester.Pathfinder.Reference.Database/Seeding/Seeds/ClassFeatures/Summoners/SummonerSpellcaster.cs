using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class SummonerSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Summoner Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your link to your eidolon grants you limited magic connected to your eidolon's nature. You can cast spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells. Because of the magic you draw from your eidolon, you can usually replace material components with somatic components, so you don't need a material component pouch." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each day, you can cast one 1st-level spell and five cantrips. You must know spells to cast them, and you learn them via the spell repertoire class feature. The number of spells you can cast each day is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a summoner, the magical link with your eidolon grants you additional, more powerful spell slots. Your total number of spell slots and the highest level of spells you can cast are shown in Table 2–4: Summoner Spells per Day. Because of the way you draw magic from your connection to your eidolon, you begin to lose lower-level spell slots once you reach 5th level. The maximum number of spell slots you get from the summoner class is four, starting when you reach 4th level." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Charisma, your spell attack rolls and spell DCs use your Charisma modifier. " };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Cantrips
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Spells
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 1, spellSlotLevel: 1, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 2, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 2, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 9, amount: 2);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
