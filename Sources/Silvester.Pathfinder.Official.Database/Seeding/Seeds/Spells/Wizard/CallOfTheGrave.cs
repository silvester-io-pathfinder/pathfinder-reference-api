using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CallOfTheGrave : Template
    {
        public static readonly Guid ID = Guid.Parse("2386265e-8204-4fe2-b54c-f13c8c5c9c1f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Call of the Grave",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 living creature.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2386265e-8204-4fe2-b54c-f13c8c5c9c1f"), Type = TextBlockType.Text, Text = "You fire a ray of sickening energy. Make a spell attack roll." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2386265e-8204-4fe2-b54c-f13c8c5c9c1f"),
                CriticalSuccess = "The target becomes sickened 2 and slowed 1 as long as it’s sickened.",
                Success = "The target becomes sickened 1.",
                Failure = "The target is unaffected.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Arcane.ID;
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2386265e-8204-4fe2-b54c-f13c8c5c9c1f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
