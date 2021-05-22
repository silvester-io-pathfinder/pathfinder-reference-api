using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RustingGrasp : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rusting Grasp",
                Level = 4,
                Range = "Touch.",
                Targets = "1 metal creature, 1 non-magical metal hazard, or 1 non-magical metal item of up to 1 Bulk.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You cause the target to rapidly rust. This magical rust can affect nonferrous materials, but the target must be all or mostly metal. Skymetals such as adamantine and orichalcum are immune to this rust, and the GM might determine other precious materials are similarly resilient. Ultimately, the GM decides if an object or creature can be targeted with this spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "All damage from this spell ignores Hardness. If the spell causes persistent damage from rust, a creature can attempt to scrape off the rust to assist the target in recovering from the persistent damage (reducing the DC of the flat check to end persistent damage to 10 and granting an immediate flat check). The effect of the spell depends on its target." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Creature or Hazard - A creature or hazard must be made of all or mostly metal to be affected (this includes many mechanical traps). It takes 8d6 damage (basic Fortitude save), plus 2d6 persistent damage on a failed save. Touching a hazard to affect it with this spell might trigger the hazard, as determined by the GM." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Item - The rust deals 2d6 damage, subject to a basic Reflex save by the creature wearing or holding the item; if the item is unattended, it automatically gets a critical failure. On a failed save, the item also takes 1d6 persistent damage. For an attended item, this persistent damage occurs at the end of the attending creature’s turns; if the item was unattended when you Cast the Spell, the damage happens at the end of your turns." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When targeting armor someone is wearing, its Bulk is 1 higher than the listed value, since carrying armor is more cumbersome than wearing it. Thin iron or steel items, such as weapons, have 20 HP and a Broken Threshold of 10, and thicker iron or steel items, such as most suits of armor, have 36 HP and a Broken Threshold of 18. Other materials’ statistics can be found on pages 577–579 of the Core Rulebook." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Increase the initial damage to creatures or hazards by 2d6, and increase the maximum Bulk of an item you can target by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 223
            };
        }
    }
}
