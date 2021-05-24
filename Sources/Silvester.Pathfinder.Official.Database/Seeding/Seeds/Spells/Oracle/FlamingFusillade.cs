using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FlamingFusillade : Template
    {
        public static readonly Guid ID = Guid.Parse("233f2ea3-dcd8-4e66-8fd4-23c3da97f7ae");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flaming Fusillade",
                Level = 6,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ecd9ec1-e07a-4792-ba73-7e6dcf0498db"), Type = TextBlockType.Text, Text = "You call upon an endless barrage of flames, producing miniature fireballs in your hands to hurl at foes. You cast produce flame as part of casting flaming fusillade. For the duration of flaming fusillade, produce flame’s casting time is reduced from 2 actions to 1." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7b3eae82-525a-4368-9e84-779556343ac2"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("56118699-a92f-49bf-b323-2eea469e36d6"), Type = TextBlockType.Text, Text = "For the duration, you also gain a status bonus to the damage dealt by produce flame equal to flaming fusillade’s spell level." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("201018e0-297d-488e-a93d-530557bd4417"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
