using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AqueousOrb : Template
    {
        public static readonly Guid ID = Guid.Parse("cfdf59f3-be1e-47b3-a367-0b7416297ab9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Aqueous Orb",
                Level = 3,
                Range = "60 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d41e09c-0e1f-49de-950a-04d8875f3b49"), Type = TextBlockType.Text, Text = "A sphere of water 10 feet in diameter forms in an unoccupied space in range, either on the ground or on the surface of a liquid. When you Cast the Spell and each time you Sustain the Spell, you can roll the orb, moving it up to 10 feet along the ground or the surface of a liquid. Unlike most spells, you can gain this effect multiple times in the same round by Sustaining the Spell multiple times. The orb can move through the spaces of any creatures or obstacles that wouldn't stop the flow of water. It extinguishes non-magical fires it moves through of its size or smaller, and it attempts to counteract any magical fires it moves through. If it fails to counteract a given fire, it can't counteract that fire for the duration of the spell." };
            yield return new TextBlock { Id = Guid.Parse("ef1e6450-3311-40b5-a15f-547086132d72"), Type = TextBlockType.Text, Text = "The orb can also collect creatures it moves through. Any Large or smaller creature whose space the orb tries to move through can attempt a Reflex save against your spell DC to avoid being engulfed. If a creature succeeds at this save, it can either let the orb pass (remaining in its space or moving out of the orb's path into a space of the creature's choice) or allow itself to be pushed in front of the orb to the end of the orb's movement. The orb can try to Engulf the same creature only once per turn, even if you roll it onto a creature's space more than once." };
            yield return new TextBlock { Id = Guid.Parse("be520334-5c65-4790-b4c6-028a81094041"), Type = TextBlockType.Text, Text = "A creature that fails its save is pulled into the orb. It becomes grabbed, moves along with the orb, and must hold its breath or begin suffocating (unless it can breathe in water). An engulfed Medium or smaller creature and anyone trying to affect that creature follow the normal rules for aquatic battles (Core Rulebook 478). An engulfed Large creature is usually big enough that parts of it stick out from the water, and it can reach out of the water. An engulfed creature can get free either by Swimming with a successful DC 10 Athletics check or by Escaping against your spell DC. A creature that critically failed its Reflex save is further stuck and must attempt to Escape instead of Swim. A freed creature exits the orb's space and can immediately breathe. The orb can contain as many creatures as can fit in its space." };
            yield return new TextBlock { Id = Guid.Parse("68d2b647-d6a4-44dc-b640-e7c942991cec"), Type = TextBlockType.Text, Text = "When the spell ends, all creatures the orb has engulfed are automatically released." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4f1c9284-2882-4d74-b57c-c1cdc4ae57a3"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("6f43fdaf-e4cd-4700-84a3-8c8f524278a8"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f47481e6-3957-4cef-8036-98395db66411"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 214
            };
        }
    }
}
