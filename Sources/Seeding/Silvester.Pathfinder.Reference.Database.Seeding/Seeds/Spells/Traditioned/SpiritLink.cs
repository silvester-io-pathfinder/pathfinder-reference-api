using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritLink : Template
    {
        public static readonly Guid ID = Guid.Parse("4850d749-4412-4255-9906-be1cd69cafa7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spirit Link",
                Level = 1,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6efad0cb-ab8b-43e5-bc75-50ca5e4d5bab"), Type = TextBlockType.Text, Text = "You form a spiritual link with another creature, taking in its pain. When you Cast this Spell and at the start of each of your turns, if the target is below maximum Hit Points, it regains 2 Hit Points (or the difference between its current and maximum Hit Points, if that's lower). You lose as many Hit Points as the target regained." };
            yield return new TextBlock { Id = Guid.Parse("aca045a9-ccee-4372-a55d-52c42ced44f2"), Type = TextBlockType.Text, Text = "This is a spiritual transfer, so no effects apply that would increase the Hit Points the target regains or decrease the Hit Points you lose. This transfer also ignores any temporary Hit Points you or the target have. Since this effect doesn't involve positive or negative energy, spirit link works even if you or the target is undead. While the duration persists, you gain no benefit from regeneration or fast healing. You can Dismiss this spell, and if you're ever at 0 Hit Points, spirit link ends automatically." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("563990c5-514e-45d1-8df2-d3c29eeaf8ec"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("392eb23e-1403-40d1-9786-f70fd4ba5934"), Type = TextBlockType.Text, Text = "The number of Hit Points transferred each time increases by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84ed1990-1644-4fd6-aacd-281d6401574c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
