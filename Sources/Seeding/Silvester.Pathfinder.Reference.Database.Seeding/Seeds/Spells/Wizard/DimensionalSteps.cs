using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DimensionalSteps : Template
    {
        public static readonly Guid ID = Guid.Parse("bb70a364-2242-498f-86f3-8d6d07c0c7d9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dimensional Steps",
                Level = 4,
                Range = "20 feet.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de0cd043-c400-4940-9dab-6aba37d4260e"), Type = TextBlockType.Text, Text = "You teleport to a location up to 20 feet away within your line of sight." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f2c95bf1-e870-4baf-803c-b56d64e62fbc"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f40f96f4-ce9d-40bc-9add-5c65401b6511"), Type = TextBlockType.Text, Text = "The distance you can teleport increases by 5 feet." }
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
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90103c3c-64a2-456c-aaa7-0eefc64a4815"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
