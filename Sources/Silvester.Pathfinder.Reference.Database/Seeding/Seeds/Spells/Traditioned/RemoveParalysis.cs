using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RemoveParalysis : Template
    {
        public static readonly Guid ID = Guid.Parse("9dd0a647-ed3c-458c-8486-ddd748e880ff");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Remove Paralysis",
                Level = 2,
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c32fc5e-0167-4f91-a67a-ac502f5266ab"), Type = TextBlockType.Text, Text = "A surge of energy frees a paralyzed creature. You can attempt to counteract a single effect imposing the paralyzed condition on the target. This does not cure someone who is paralyzed from some natural state or effect, such as paralysis caused by non-magical wounds or toxins." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fbe9f92c-d1d5-4c4b-92c2-12b16df2f941"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("30ec13d7-e710-4c1d-87fd-1fff984eb312"), Type = TextBlockType.Text, Text = "The spell’s range increases to 30 feet, and you can target up to 10 creatures." }
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
            yield return MagicTraditions.Instances.Primal.ID;
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
                Id = Guid.Parse("9537588f-780f-4498-9475-26b07671c35e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}
