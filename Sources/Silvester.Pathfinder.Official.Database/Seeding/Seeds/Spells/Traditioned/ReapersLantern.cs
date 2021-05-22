using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ReapersLantern : Template
    {
        public static readonly Guid ID = Guid.Parse("e50acbc3-bb22-4c29-9b74-c9ffb2d7d13e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Reaper's Lantern",
                Level = 2,
                Area = "5-foot emanation.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba8683f5-4629-482b-99f6-d92efc68a298"), Type = TextBlockType.Text, Text = "You call forth a ghostly lantern that guides the living toward death and the undead toward true death. It sheds bright light in the spell’s area, and dim light to twice that area. Though the lantern is insubstantial, you must keep a hand free to hold it or the spell ends (though using the hand for somatic spell components doesn’t end the spell). Living creatures and undead in the area when you Cast the Spell, or that enter the area later, must attempt Fortitude saves. Living creatures that fail their Fortitude saves gain only half the normal benefit from healing effects while within the area. Undead targets that fail their Fortitude saves become enfeebled 1 while within the area. Once a creature attempts a save against reaper’s lantern, it uses the same outcome if it leaves the area and enters it again." };
            yield return new TextBlock { Id = Guid.Parse("8c41b70e-17a4-4fd6-b223-ba57f28955d4"), Type = TextBlockType.Text, Text = "Once per turn, starting on the turn after you cast reaper’s lantern, you can use a single action, which has the concentrate trait, to increase the emanation’s radius by 5 feet. When you do so, you force creatures in the area that haven’t yet attempted a save against reaper’s lantern to attempt one." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e3448aa-3ce1-42a6-8129-73d2a73b644c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 223
            };
        }
    }
}
