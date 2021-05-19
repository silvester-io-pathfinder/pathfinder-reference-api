using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Grease : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Grease",
                Level = 1,
                Range = "30 feet.",
                Area = "4 contiguous 5-foot squares or 1 object of 1 Bulk or less.",
                Duration = "1 minute.",
                Targets = "1 object of 1 Bulk or less.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You conjure grease, with effects based on choosing area or target." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Area" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "All solid ground in the area is covered withgrease. Each creature standing on the greasy surface must succeed at a Reflex save or an Acrobatics check against your spell DC or fall prone. Creatures using an action to move onto the greasy surface during the spell’s duration must attempt either a Reflex save or an Acrobatics check to Balance. A creature that Steps or Crawls doesn’t have to attempt a check or save." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Target" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you cast the spell on an unattended object, anyone trying to pick up the object must succeed at an Acrobatics check or Reflex save against your spell DC to do so. If you target an attended object, the creature that has the object must attempt an Acrobatics check or Reflex save. On a failure, the holder or wielder takes a –2 circumstance penalty to all checks that involve using the object; on a critical failure, the holder or wielder releases the item. The object lands in an adjacent square of the GM’s choice. If you cast this spell on a worn object, the wearer gains a +2 circumstance bonus to Fortitude saves against attempts to grapple them." };
        }


        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 342
            };
        }
    }
}
