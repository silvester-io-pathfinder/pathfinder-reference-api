using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class ElementalToss : Template
    {
        public static readonly Guid ID = Guid.Parse("ed49874f-ba31-44ce-9a62-4c4481c176c5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Toss",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60037700-5384-4bd4-ae26-b4209e1d8cef"), Type = TextBlockType.Text, Text = "With a flick of your wrist, you fling a chunk of your elemental matter at your foe. Make a spell attack roll, dealing 1d8 bludgeoning damage (or fire damage if your element is fire) on a success, and double damage on a critical success. This spell has your element’s trait." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3213795c-1ed9-4267-b0ed-6616276af49b"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("814d49c8-5701-40ba-b39d-8582ae1e4be7"), Type = TextBlockType.Text, Text = "The damage increases by 1d8." }
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
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("545be224-1fe3-46be-ab23-b47e5bd2efa6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
