using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class TentacularLimbs : Template
    {
        public static readonly Guid ID = Guid.Parse("7a91b60f-ae3b-4ccc-8f72-f9639a0c34dc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tentacular Limbs",
                Level = 1,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f054a874-b24c-466a-8036-20c14ee267fe"), Type = TextBlockType.Text, Text = "Your arms turn into long, pliable tentacles, increasing your reach when you’re delivering touch range spells and making unarmed Strikes with your arms (such as fist and claw Strikes) to 10 feet. This doesn’t change the reach of your melee weapon attacks. During the duration, whenever you Cast a Spell, you can add an additional action to that spell’s casting to temporarily extend your reach to 20 feet to deliver that spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("73028c4f-0213-47f6-b843-74e77dc43ff3"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f233422c-8369-4ba8-9640-c3b33ad9d9ea"), Type = TextBlockType.Text, Text = "When you add an additional action to a spell to temporarily extend your reach, your reach increases by an additional 10 feet to deliver that spell." }
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
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Sorcerer.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbc737a9-9803-41a4-8d97-067327245187"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 405
            };
        }
    }
}
