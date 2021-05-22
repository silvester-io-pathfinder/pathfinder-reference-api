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
    public class Lamashtu : Template
    {
        public static readonly Guid ID = Guid.Parse("26824bcf-2fcd-46d3-8c59-9c48233f7780");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = ChaoticEvil.ID,
                Name = "Lamashtu", 
                Description = "The Mother of Monsters is goddess of aberrance, monsters, and nightmares. She seeks to corrupt mortals and populate the world with her twisted and monstrous brood.",
                Edicts = "Bring power to outcasts and the downtrodden, indoctrinate children in Lamashtu’s teachings, make the beautiful monstrous, reveal the corruption and flaws in all things.",
                Anathema = "Attempt to treat a mental illness or deformity, provide succor to Lamashtu’s enemies.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Survival.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Family.ID;
            yield return Might.ID;
            yield return Nightmares.ID;
            yield return Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db90e5c1-b448-4b0f-b144-2da9d13c505d"),
                SourceId = CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
