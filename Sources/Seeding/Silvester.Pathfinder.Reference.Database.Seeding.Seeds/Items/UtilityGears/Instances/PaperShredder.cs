using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class PaperShredder : Template
    {
        public static readonly Guid ID = Guid.Parse("8dcb83a6-9a6c-4750-b9fe-4a1f927bb5c5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Paper Shredder",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9834473b-dc88-45fd-aa60-217e34b5582b"), "Whether it�s a parchment with ominous pentagrams and dangerous magical symbols inscribed upon it, incriminating legal documents, or just simply paper waste, sometimes you just need to make sure a document is completely destroyed in a way that makes it nearly impossible to read afterwards. Enter the paper shredder, a clockwork device that performs exactly this function.");
            builder.Text(Guid.Parse("0a3ac040-11d9-406c-8a5e-188b3bf60d86"), "With 1 minute of wind-up, a paper shredder can function for up to 1 hour of shredding, and it automatically enters standby mode when not in use, meaning the device can typically go for weeks between wind-ups unless you shred an exceptionally large volume of paper.");
            builder.Text(Guid.Parse("a555788c-1fb5-4257-b533-bdbdd6fa1dc5"), "Setting a piece of paper or parchment into the paper shredder takes a single Interact action, which means you can shred up to three pages of paper or parchment each round. If the page is longer than normal, it takes longer to shred, as determined by the GM. Additionally, only one person can use the shredder each round, limiting it to shredding three pages per round regardless of how many people are available to feed paper into it. The paper shredders rips and tears the paper or parchment apart into tiny disjointed strips. This is typically sufficient to destroy glyphs of warding and other similar dangerous magical traps on the paper, though the GM might determine that particularly resilient magical traps find some way to survive their shredding. If the paper is magically protected or otherwise has more Hardness than a normal sheet of paper or parchment, the shredder can�t shred it. After churning such hardened paper for 1 round, the shredder spits it back out without harming the shredder. This prevents shredding any other paper during that round.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5a9a628f-af84-43de-90d8-efb5527d142b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("503980e4-cab4-4ae6-b74c-d6c1ba5037fd"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("1b529ab2-8169-43a4-bc7e-2eaf9bb8caab"),
                Name = "Paper Shredder",
                Level = 2,
                Price = 3000,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df758236-c913-4796-aa64-64faa3828239"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 88
            };
        }
    }
}
