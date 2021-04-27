using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Curse : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("b52f7376-e628-4d1b-8b54-a2e0d0e69c47");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Curse",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7040488b-b67b-41c2-92a1-adf2f9241882"), Type = TextBlockType.Text, Text = "A curse is an effect that places some long-term affliction on a creature. Curses are always magical and are typically the result of a spell or trap. Effects with this trait can be removed only by effects that specifically target curses." };
            yield return new TextBlock { Id = Guid.Parse("49e325f6-058f-4df2-85b1-ccdc0a7f80e8"), Type = TextBlockType.Text, Text = "Afflictions with this trait are manifestations of potent ill will. A curse either lasts a specified amount of time or can be removed only by certain actions a character must perform or conditions they must meet. A curse with stages follows the rules for afflictions. (Gamemastery Guide pg. 251)" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8d6c4f6-3671-463b-ad13-6d269c006199"),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
