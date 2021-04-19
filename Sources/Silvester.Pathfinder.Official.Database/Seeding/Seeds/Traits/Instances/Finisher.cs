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
    public class Finisher : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Finisher",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Finishers are spectacular finishing moves that use your panache. You can use a finisher only if you have panache, and you lose your panache immediately after performing a finisher. Once you use a finisher, you can't use any actions that have the attack trait for the rest of your turn." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some actions that have the finisher trait also grant an effect on a failure. Effects added on a failure don't apply on a critical failure. If your finisher action succeeds, you can still choose to apply the failure effect instead. For example, you might do this when an attack deals no damage due to resistance." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 267
            };
        }
    }
}
