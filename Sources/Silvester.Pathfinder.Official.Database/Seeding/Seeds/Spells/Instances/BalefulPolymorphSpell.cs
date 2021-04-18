using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BalefulPolymorphSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Transmutation";
        public override string SavingThrowStat => "Fortitude";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("79fbdd8a-c496-4974-af00-14c3640841ab"),
                Name = "Baleful Polymorph",
                Level = 6,
                Range = 30,
                Targets = "1 creature.",
                Duration = "1 minute."
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("435f323d-f2ba-4a44-b7fb-05738ce88cdd"), Type = Utilities.Text.TextBlockType.Text, Text = "You transform the target creature into a harmless animal appropriate to the area, with effects based on its Fortitude save." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f5e8d362-20e3-4342-bd65-73ca29c1825b"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target’s body gains minor features of the harmless animal. Its insides churn as they partially transform, causing it to be sickened 1. When it recovers from the sickened condition, its features revert to normal.",
                Failure = "The target transforms for 1 minute but keeps its mind. If it spends all its actions on its turn concentrating on its original form, it can attempt a Will save to end the effect immediately.",
                CriticalFailure = "The target is transformed into the chosen harmless animal, body and mind, for an unlimited duration."
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Incapacitation";
            yield return "Transmutation";
            yield return "Polymorph";
        }
    }
}
