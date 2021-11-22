using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    
    public class AchaekeksClutch : Template
    {
        public static readonly Guid ID = Guid.Parse("72739db8-4d2e-4e46-9602-9920abfb7a81");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Achaekek's Clutch",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d31ca5ba-9141-4cae-9c04-9f8b4598b360"), Type = TextBlockType.Text, Text = "You mark the holy symbol of Achaekek in a visible location on the target's body." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("73fb8ebf-60a1-4cea-bbe6-84e2847f20e6"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is marked by Achaekek's symbol. For 1 minute, the first time per round that the target gains persistent bleed damage, they immediately take that amount of slashing damage as the mantis claws grow off the symbol and rake them.",
                Failure = "As success, but the curse has an unlimited duration.",
                CriticalFailure = "As failure, but the DC on the target's flat check to remove persistent bleed damage increases to 20 (15 with particularly effective assistance)."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield break;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93212c24-4c79-4c39-9302-9049cd1c84ee"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 58
            };
        }
    }
}
