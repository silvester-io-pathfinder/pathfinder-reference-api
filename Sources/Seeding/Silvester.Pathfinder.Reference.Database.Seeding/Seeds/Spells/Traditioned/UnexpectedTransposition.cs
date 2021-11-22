using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnexpectedTransposition : Template
    {
        public static readonly Guid ID = Guid.Parse("f953a5b5-fec3-4577-9dd4-28a435611aef");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unexpected Transposition",
                Level = 6,
                Range = "30 feet.",
                Trigger = "You are targeted with an enemy�s Strike.",
                Targets = "1 creature other than the triggering enemy.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b46ac7eb-77c9-401e-9d05-a2cae0387b43"), Type = TextBlockType.Text, Text = "When attacked, you attempt to quickly swap your own position with that of another creature. A creature that is unwilling to swap places with you must attempt a Will save. Willing creatures automatically fail. If you successfully switch places with the target, the triggering attack is resolved against that creature as if it had been the original target of the attack. After the swap, you and the target are both temporarily immune to unexpected transposition spells for 1 minute. You automatically switch places if the target is willing. If it�s unwilling, it can attempt a Will save. Neither of you teleports if the target succeeds at its save." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("add23c9e-abb6-4005-92ed-5badefb91459"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 138
            };
        }
    }
}
