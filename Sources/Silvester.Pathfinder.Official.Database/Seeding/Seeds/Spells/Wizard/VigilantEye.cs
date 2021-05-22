using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class VigilantEye : Template
    {
        public static readonly Guid ID = Guid.Parse("e708c2d7-0733-4270-bdcc-d4b3be57a73f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vigilant Eye",
                Level = 4,
                Range = "500 feet.",
                Duration = "1 hour.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e708c2d7-0733-4270-bdcc-d4b3be57a73f"), Type = TextBlockType.Text, Text = "You create an invisible eye sensor, as clairvoyance (page 324). When created, this eye must be in your line of sight." };
            yield return new TextBlock { Id = Guid.Parse("e708c2d7-0733-4270-bdcc-d4b3be57a73f"), Type = TextBlockType.Text, Text = "When the spell’s duration ends, you can spend 1 Focus Point as a free action to extend the duration for another hour, though as normal, it ends immediately during your next daily preparations." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e708c2d7-0733-4270-bdcc-d4b3be57a73f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
