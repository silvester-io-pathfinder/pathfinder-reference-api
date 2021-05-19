using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses.Champion.Instances
{
    public class LitanyOfRighteousness : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Focus GetFocus()
        {
            return new Focus
            {
                Id = ID,
                Name = "Litany of Righteousness",
                Level = 7,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 evil creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                FocusTypeId = FocusTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your litany denounces an evildoer, rendering it susceptible to the powers of good. The target gains weakness 7 to good. The target then becomes temporarily immune to all of your litanies for 1 minute." };
        }

        public override IEnumerable<FocusHeightening> GetHeightenings()
        {
            yield return new FocusHeightening
            {
                Id = Guid.Parse(""),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The weakness increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Champion.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Good.ID;
            yield return Traits.Instances.Litany.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 388
            };
        }
    }
}
