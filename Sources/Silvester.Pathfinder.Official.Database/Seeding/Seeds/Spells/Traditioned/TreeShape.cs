using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TreeShape : Template
    {
        public static readonly Guid ID = Guid.Parse("abd09dc0-7486-407a-aa13-d1ae5fde0e5d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tree Shape",
                Level = 2,
                IsDismissable = true,
                Duration = "8 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22a688f2-2be2-4965-a0b2-07965d30f797"), Type = TextBlockType.Text, Text = "You transform into a Large tree. Perception checks don’t reveal your true nature, but a successful Nature or Survival check against your spell DC reveals that you appear to be a tree that is strangely new to the area. While in tree form, you can observe everything around you, but you can’t act other than to end the spell, and your turn, by using a single action, which has the concentrate trait. As a tree, your AC is 20, and only status bonuses, status penalties, circumstance bonuses, and circumstance penalties affect you. Any successes and critical successes you roll on Reflex saves are failures." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Plant.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3981af5f-ea17-4658-afd3-2ef5ed95fc7c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 378
            };
        }
    }
}
