using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class ArcaneCountermeasure : Template
    {
        public static readonly Guid ID = Guid.Parse("e55208da-89f5-4826-95b0-d06033055d12");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Arcane Countermeasure",
                Level = 5,
                Trigger = "A creature within range that you can see Casts a Spell.",
                Range = "120 feet.",
                Targets = "The spell cast by the triggering creature.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4ef6d5e-6e25-4611-9cc3-10681463f4bb"), Type = TextBlockType.Text, Text = "You undermine the target spell, making it easier to defend against. You reduce the spell’s level by 1, and targets of the spell gain a +2 status bonus to any saving throws, skill checks, AC, or DC against it." };
            yield return new TextBlock { Id = Guid.Parse("bb4070a4-d683-4a04-852b-c4e435447513"), Type = TextBlockType.Text, Text = "You can’t reduce the spell’s level below its minimum. For example, a 5th-level cone of cold would remain 5th-level, but a 5th-level fireball would become 4th-level. Targets still gain all the other benefits, even if you don’t reduce the spell’s level." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb3e77da-cf56-43aa-95ee-1dd3f1ba0dee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
