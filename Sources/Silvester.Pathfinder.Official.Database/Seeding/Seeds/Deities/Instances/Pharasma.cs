using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Deities.Instances
{
    public class Pharasma : Template
    {
        public static readonly Guid ID = Guid.Parse("999199bf-2d79-498b-a631-03de699011d4");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = TrueNeutral.ID,
                Name = "Pharasma", 
                Description = "Ancient and powerful beyond even most other gods, the Lady of Graves presides over birth, death, fate, and prophecy. From her throne in the Boneyard, she judges the souls of all who perish, and she ensures that the natural cycle of birth and death—the River of Souls—is not disrupted.",
                Edicts = "Strive to understand ancient prophecies, destroy undead, lay bodies to rest.",
                Anathema = "Create undead, desecrate a corpse, rob a tomb.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Death.ID;
            yield return Fate.ID;
            yield return Healing.ID;
            yield return Knowledge.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return NeutralGood.ID;
            yield return TrueNeutral.ID;
            yield return LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e69d0f5-b883-437f-bffa-14c1252817bf"),
                SourceId = CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
