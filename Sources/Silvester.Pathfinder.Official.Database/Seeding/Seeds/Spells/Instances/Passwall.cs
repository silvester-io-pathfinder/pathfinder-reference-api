using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Passwall : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Passwall",
                Level = 5,
                Area = "5-foot-wide, 10-foot-tall, 10-foot-deep section of wooden, plaster or stone wall.",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You create a visible tunnel through the wall in the chosen area, replacing the area with empty space. If the wall is thicker than 10 feet, the tunnel ends 10 feet in. Even a small layer of metal in the wall prevents this spell from functioning. This spell doesn’t reduce the integrity of the structure. When the spell ends, anyone inside the tunnel is shunted to the nearest exit." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The tunnel can be up to 20 feet deep. The areas of the wall that contain your tunnel’s entrance appear completely normal (unless viewed with true seeing or a similar effect), despite the tunnel’s existence. The tunnel’s entrance functions as a solid wall, but you can specify a password or a trigger (page 305), allowing creatures to enter the tunnel freely." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Earth.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 356
            };
        }
    }
}
