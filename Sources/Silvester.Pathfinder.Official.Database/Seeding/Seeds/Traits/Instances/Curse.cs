using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Curse : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Curse",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A curse is an effect that places some long-term affliction on a creature. Curses are always magical and are typically the result of a spell or trap. Effects with this trait can be removed only by effects that specifically target curses." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Afflictions with this trait are manifestations of potent ill will. A curse either lasts a specified amount of time or can be removed only by certain actions a character must perform or conditions they must meet. A curse with stages follows the rules for afflictions. (Gamemastery Guide pg. 251)" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = CoreRulebook.ID,
                Page = 630
            };
        }
    }
}
