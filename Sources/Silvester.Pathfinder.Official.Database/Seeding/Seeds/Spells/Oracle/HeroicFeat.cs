using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class HeroicFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("d273f2b3-f03a-4647-8eb8-3b9bbd3add82");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Heroic Feat",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoOrThreeActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5521c85-ee87-44a8-b9c2-dcc7b0c21f64"), Type = TextBlockType.Text, Text = "You gain the ability to perform a specialized combat technique from the vast wealth of martial knowledge your mystery provides. When you Cast this Spell, you use the action granted by one common fighter feat from pages 144–153 of the Core Rulebook or pages 126–127 of this book (your GM might add feats to this list). If you Cast this Spell using 2 actions, the granted action must be a single action, and if you Cast this Spell using 3 actions, you can instead choose a feat that grants a 2-action activity. The chosen feat’s level can be no higher than heroic feat’s spell level. The feat can’t have a Frequency entry, and you must meet its prerequisites and requirements in order to select it." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e4fb831-247d-4a38-9f23-5c6aa8959fec"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
