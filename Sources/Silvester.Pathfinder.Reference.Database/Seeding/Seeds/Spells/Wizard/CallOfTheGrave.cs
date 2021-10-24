using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CallOfTheGrave : Template
    {
        public static readonly Guid ID = Guid.Parse("2fed231b-fe88-4fdb-92b9-ab355e578dcc");

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
            yield return new TextBlock { Id = Guid.Parse("a3f4fd4b-027d-48ac-b19c-407c1842dfad"), Type = TextBlockType.Text, Text = "You fire a ray of sickening energy. Make a spell attack roll." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1e1da503-72b1-4262-bd9f-5e0875a6180e"),
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
                Id = Guid.Parse("5e7c25d4-3d53-414b-90f6-9ffa21b1b82d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
