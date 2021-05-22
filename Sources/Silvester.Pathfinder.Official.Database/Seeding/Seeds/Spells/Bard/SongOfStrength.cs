using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SongOfStrength : Template
    {
        public static readonly Guid ID = Guid.Parse("22696413-6532-4ce7-8654-0eaf8016fe09");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Song of Strength",
                Level = 1,
                Area = "60-foot emanation.",
                Duration = "1 round.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1dcf5217-ebc4-49e2-be67-5ef904508085"), Type = TextBlockType.Text, Text = "You bolster your allies’ physical strength with a hearty exhortation. You and your allies gain a +1 status bonus to Athletics checks and to their DCs against Athletics skill actions such as Disarm, Shove, and Trip." };
            yield return new TextBlock { Id = Guid.Parse("56ebfff1-2351-4788-b92f-6bb07371a737"), Type = TextBlockType.Enumeration, Text = "Special - If you have the inspire heroics composition spell, you can use that composition to improve the bonus granted by song of strength in the same way as inspire courage or inspire defense." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95f73e75-468a-4175-af80-793e8bf89d40"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 228
            };
        }
    }
}
