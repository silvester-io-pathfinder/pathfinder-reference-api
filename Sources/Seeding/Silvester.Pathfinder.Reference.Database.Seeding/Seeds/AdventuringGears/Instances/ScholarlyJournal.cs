using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class ScholarlyJournal : Template
    {
        public static readonly Guid ID = Guid.Parse("ca17eabb-a025-4f95-9f26-f5b4a6aeef15");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Scholarly Journal",
                Hands = "1",
                Price = 600,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b255fac2-e663-459a-8325-3cc9840b46da"),
                NameAddendum = "Compendium",
                DescriptionAddendum = "A compendium of journals costs five times as much as a single journal and requires both hands to use; each compendium contains several journals and grants its bonus on a broader topic, such as all undead or a whole city.",
                ItemLevel = 3,
                Price = 3000,
                Hands = 2,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9c6fea82-da67-4969-9ada-c5624a22b86c"), Type = TextBlockType.Text, Text = "Scholarly journals are uncommon. Each scholarly journal is a folio on a very specific topic, such as vampires or the history of a single town or neighborhood of a city. If you spend 1 minute referencing an academic journal before attempting a skill check to Recall Knowledge about the subject, you gain a +1 item bonus to the check. The GM determines what scholarly journals are available in any location." };
            yield return new TextBlock { Id = Guid.Parse("79fefac6-d163-4598-aa5f-b74521c02b83"), Type = TextBlockType.Text, Text = "All characters have access to the scholarly journal, scholarly journal compendium, survey map, and survey map atlas." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("687cad0d-7f10-46a5-98a1-39276f204693"),
                SourceId = CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
