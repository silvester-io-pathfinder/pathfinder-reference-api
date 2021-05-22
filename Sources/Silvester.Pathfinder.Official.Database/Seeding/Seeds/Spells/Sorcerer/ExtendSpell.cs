using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class ExtendSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("03c07d79-4b6f-4cf2-bcbd-a265ab9082fc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Extend Spell",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5aefd9cf-d729-4b9a-a992-04a8dcdf4593"), Type = TextBlockType.Text, Text = "You call upon your blood’s knowledge of the ancients to extend your magic. If your next action is to Cast a Spell with a duration of 1 minute and a single target, the spell instead lasts 10 minutes. You can extend a spell only if you cast it from a spell slot lower than your highest spell slot, and you can have only one active spell at a time extended in this way." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Metamagic.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3af85be4-a758-4213-aa7e-5e504374628f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
