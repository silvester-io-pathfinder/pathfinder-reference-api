using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class GustOfWind : Template
    {
        public static readonly Guid ID = Guid.Parse("182823a4-0b66-4bfe-a4fa-79dfd4fb5abf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Gust of Wind",
                Level = 1,
                Area = "60-foot line.",
                Duration = "Until the start of your next turn.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cb0a97e-b278-4a4e-bd77-039a29c97718"), Type = TextBlockType.Text, Text = "A violent wind issues forth from your palm, blowing from the point where you are when you cast the spell to the line’s opposite end. The wind extinguishes small non-magical fires, disperses fog and mist, blows objects of light Bulk or less around, and pushes larger objects. Large or smaller creatures in the area must attempt a Fortitude save. Large or smaller creatures tha" };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f301d0a7-d720-41f4-8f76-d7b419a731cb"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature can’t move against the wind.",
                Failure = "The creature is knocked prone. If it was flying, it suffers the effects of critical failure instead.",
                CriticalFailure = "The creature is pushed 30 feet in the wind’s direction, knocked prone, and takes 2d6 bludgeoning damage."
            };
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
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6aa5b814-adcb-4d99-865a-924e20ded84b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 342
            };
        }
    }
}
