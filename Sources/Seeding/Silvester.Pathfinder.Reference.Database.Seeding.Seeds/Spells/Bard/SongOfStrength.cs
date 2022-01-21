using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("1dcf5217-ebc4-49e2-be67-5ef904508085"), Type = TextBlockType.Text, Text = "You bolster your allies' physical strength with a hearty exhortation. You and your allies gain a +1 status bonus to Athletics checks and to their DCs against Athletics skill actions such as Disarm, Shove, and Trip." };
            yield return new TextBlock { Id = Guid.Parse("56ebfff1-2351-4788-b92f-6bb07371a737"), Type = TextBlockType.Enumeration, Text = "Special - If you have the inspire heroics composition spell, you can use that composition to improve the bonus granted by song of strength in the same way as inspire courage or inspire defense." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("74bb098f-ed74-4c64-a1fd-4020399caa12"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5941c40e-9968-4eed-9632-13d88f9e13b9"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("bf8b7a4b-40d9-476a-844b-c5178ed996fc"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("0e3aa823-d0b8-4def-86e0-2bad72ce8a9d"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("134700b5-9ca9-4682-8e6a-7c39428bf53b"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("2154a8e2-cd5b-462d-94bc-ae035fd76bb5"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("d2e0d458-da9c-448d-9431-ecc69737c672"), Traits.Instances.Mental.ID);
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
