using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PerfectedForm : Template
    {
        public static readonly Guid ID = Guid.Parse("97fde3d9-4ac8-4ad7-9813-fdc8cd1b149b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Perfected Form",
                Level = 4,
                Trigger = "You fail a saving throw against a morph, petrification, or polymorph effect.",
                DomainId = Domains.Instances.Perfection.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97f6203f-83db-4301-98db-0abe72b0b346"), Type = TextBlockType.Text, Text = "Reroll the saving throw and use the better result." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0537f609-24ef-4916-8043-b25aec0266d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
