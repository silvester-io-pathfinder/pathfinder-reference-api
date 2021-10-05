using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DelayAffliction : Template
    {
        public static readonly Guid ID = Guid.Parse("15df34e2-0c94-44cd-98a5-6f73fed08d59");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Delay Affliction",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c096d15-ee2e-465d-b643-9ef68c89243b"), Type = TextBlockType.Text, Text = "With a surge of healing energy, you push back against an affliction threatening the target and grant a small amount of healing. The target recovers 3d8 Hit Points. You attempt to counteract any one affliction you are aware the target has, suspending its effects for 1 hour on a success rather than removing it. The target is then temporarily immune to delay affliction for 1 day. You don’t need to have identified the name of the specific affliction, but you do need to be aware of it; for instance, you couldn’t delay an ingested poison during its onset period unless you were aware of the poison." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("02cb4cbe-0abc-44f0-978f-6db6a42a543c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2e707adf-7fcf-4b83-9e14-4e734eed6bbf"), Type = TextBlockType.Text, Text = "The target recovers an additional 1d8 Hit Points and you can attempt to suspend an additional affliction." }
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
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Oracle.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd6dc580-a145-4930-ba07-4ae611001c9c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 231
            };
        }
    }
}
