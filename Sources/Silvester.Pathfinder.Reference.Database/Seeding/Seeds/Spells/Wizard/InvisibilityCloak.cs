using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InvisibilityCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("f503eac1-c815-415f-978b-7bf2732abe4e");

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
            yield return new TextBlock { Id = Guid.Parse("4a53ba84-6949-4eab-aa4b-c8d4f8800a0a"), Type = TextBlockType.Text, Text = "You become invisible, with the same restrictions as the 2nd-level invisibility spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cbade54a-5323-43f3-9991-cb882ec80a8b"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("05194068-0c39-4284-a1d0-a90a9d78025d"), Type = TextBlockType.Text, Text = "The duration increases to 10 minutes." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("01094262-0c6d-4d42-bbf6-b8d0b1f250df"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("104b2fba-3c0b-478f-9b23-9d953f02c808"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
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
                Id = Guid.Parse("12bcf809-793a-4c45-8d56-ae9f033208f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
