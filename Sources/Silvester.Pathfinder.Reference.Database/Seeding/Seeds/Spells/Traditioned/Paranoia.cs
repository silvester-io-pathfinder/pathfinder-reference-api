using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Paranoia : Template
    {
        public static readonly Guid ID = Guid.Parse("4ef54f62-e2b5-4230-9279-82e61be830a8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Paranoia",
                Level = 2,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
             yield return new TextBlock { Id = Guid.Parse("4bc1c82c-1488-4836-8495-82fb7717b33c"), Type = TextBlockType.Text, Text = "You cause the target to see all other creatures as dire threats. The target is stricken by intense paranoia toward all creatures around it and must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("96751da4-13c5-400b-9a6a-9f1a3c1a5858"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0948c583-7192-4440-8e7b-2aa62e1600d1"), Type = TextBlockType.Text, Text = "You can target up to 5 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8e82d049-9724-436b-b4ea-1308c590bf5a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target believes everyone it sees is a potential threat. It becomes unfriendly to all creatures to which it wasn’t already hostile, even those that were previously allies. It treats no one as an ally. The spell ends after 1 round.",
                Failure = "As success, but the effect lasts 1 minute.",
                CriticalFailure = "As failure, except the target believes that everyone it sees is a mortal enemy. It uses its reactions and free actions against everyone, regardless of whether they were previously its allies, as determined by the GM. It otherwise acts as rationally as it normally does and likely prefers to attack creatures that are actively attacking or hindering it over those leaving it alone."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c90299f0-a9fb-47dc-b08d-29a26673385f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 356
            };
        }
    }
}
