using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InstantArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("94aab80c-52ea-424f-b4e9-76c517e4f868");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Instant Armor",
                Level = 2,
                Duration = "24 houts.",
                CastTime = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7a1ec60e-a06d-4e14-a08d-da6ea1a6251e"), Type = TextBlockType.Text, Text = "Upon casting this spell, the armor you�re wearing is whisked away into an extradimensional space that�s linked to you. If the armor is magical and invested by you, it remains invested while in this space, though you don�t gain its benefits. You then gain the Armor Up! action; once you use the action, the spell ends. If the action hasn�t been used by the time the spell�s duration ends, the extradimensional space collapses, ejecting the armor�s pieces on the ground under you." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("fb0ace1d-401a-40a2-8f8e-2c7ed22250c2"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Armor Up",
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("d6a61e32-b58c-4607-a5ce-87f5a1ab74e0"), Type = TextBlockType.Text, Text = "You snap your fingers. The armor returns to your body." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Contingency.ID;
            yield return Traits.Instances.Extradimensional.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aca29956-18f4-49f2-8f21-a81150493237"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 112
            };
        }
    }
}
