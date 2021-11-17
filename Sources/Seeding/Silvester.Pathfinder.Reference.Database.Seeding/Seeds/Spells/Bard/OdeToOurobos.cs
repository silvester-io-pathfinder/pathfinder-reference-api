using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class OdeToOurobos : Template
    {
        public static readonly Guid ID = Guid.Parse("41923abd-01b6-44e1-9591-e76f9ccd65e4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ode to Ourobos",
                Level = 5,
                Range = "60 feet.",
                Targets = "The triggering creature.",
                Trigger = "A creature’s dying condition would reach the value at which they would die.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }


        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d141a0f-93d6-48ef-a607-01554a481807"), Type = TextBlockType.Text, Text = "Your ode temporarily staves off death. The target’s dying condition remains 1 below the value at which it dies. This doesn’t help prevent death from effects that kill the target without increasing its dying condition, such as disintegrate and death effects." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("195dc1c8-5a37-47d2-b128-5724d70eb21a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 228
            };
        }
    }
}
