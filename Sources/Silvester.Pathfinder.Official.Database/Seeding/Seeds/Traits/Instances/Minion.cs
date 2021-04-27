using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Minion : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("75132a55-72ac-415c-b405-37c2530bce76");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Minion",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4cecccf-e509-49f9-8793-9447d6b9a97d"), Type = TextBlockType.Text, Text = "Minions are creatures that directly serve another creature. A creature with this trait can use only 2 actions per turn and can’t use reactions. Your minion acts on your turn in combat, once per turn, when you spend an action to issue it commands. For an animal companion, you Command an Animal; for a minion that’s a spell or magic item effect, like a summoned minion, you Sustain a Spell or Sustain an Activation; if not otherwise specified, you issue a verbal command, a single action with the auditory and concentrate traits. If given no commands, minions use no actions except to defend themselves or to escape obvious harm. If left unattended for long enough, typically 1 minute, mindless minions usually don’t act, animals follow their instincts, and sapient minions act how they please." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bcbb8f6a-8a9e-428e-8c25-e658c486d315"),
                SourceId = CoreRulebook.ID,
                Page = 634
            };
        }
    }
}
