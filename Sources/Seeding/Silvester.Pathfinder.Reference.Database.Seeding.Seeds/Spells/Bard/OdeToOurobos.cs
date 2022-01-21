using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
                Trigger = "A creature's dying condition would reach the value at which they would die.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }


        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d141a0f-93d6-48ef-a607-01554a481807"), Type = TextBlockType.Text, Text = "Your ode temporarily staves off death. The target's dying condition remains 1 below the value at which it dies. This doesn't help prevent death from effects that kill the target without increasing its dying condition, such as disintegrate and death effects." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("fa236c99-c34a-4116-a72b-61672468a177"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("903713d8-f1b3-4bbc-9c62-fa702274804d"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("ed518732-42aa-4565-b4a3-bfb850b6e91d"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("41f69eb9-396d-47bc-8c3f-e8b6e8914297"), Traits.Instances.Necromancy.ID);
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
