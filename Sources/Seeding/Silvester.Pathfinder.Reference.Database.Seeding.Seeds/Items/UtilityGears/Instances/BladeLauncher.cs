using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class BladeLauncher : Template
    {
        public static readonly Guid ID = Guid.Parse("7a3fbc03-66bf-4e98-b76c-bb9114c58e15");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Blade Launcher",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0519a0cc-baac-4902-93af-cca5b64534a5"), "A blade launcher has a bow-like assembly mounted on a handled frame. The frame can be configured to fire either a dagger, dart, shuriken, or starknife. Configuring a blade launcher requires three Interact actions. Once properly configured, loading an appropriate thrown weapon into a blade launcher requires a single Interact action. A blade launcher can't fire weapons for which it's not currently configured. A weapon fired with a blade launcher loses the agile, monk, thrown, and versatile traits, if it has them, and has a range increment of 40 feet. Due to losing the thrown weapon trait, returning and most other effects that allow a weapon to return don't function; even if a launched weapon did return, you'd still need to load it into the blade launcher with an Interact action to fire the blade launcher again.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8b61ec3e-cdf6-4015-8b0c-35879dff4a19"), Traits.Instances.Uncommon.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("bd246f56-dea4-4d73-84cd-c8f4ff07c536"),
                Name = "Blade Launcher",
                Usage = "Held in 2 hands.",
                Level = 1,
                Price = 1800,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90200dbb-702a-4e87-9a0e-0f3956e67867"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 64
            };
        }
    }
}
