using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class InvisibilityCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("fce27717-be6f-433a-aef8-cafb6261eff1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Invisibility Cloak",
                Level = 4,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fce27717-be6f-433a-aef8-cafb6261eff1"), Type = TextBlockType.Text, Text = "You become invisible, with the same restrictions as the 2nd-level invisibility spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("fce27717-be6f-433a-aef8-cafb6261eff1"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fce27717-be6f-433a-aef8-cafb6261eff1"), Type = TextBlockType.Text, Text = "The duration increases to 10 minutes." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("fce27717-be6f-433a-aef8-cafb6261eff1"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fce27717-be6f-433a-aef8-cafb6261eff1"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fce27717-be6f-433a-aef8-cafb6261eff1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
