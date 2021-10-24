using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineFonts.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Abadar : Template
    {
        public static readonly Guid ID = Guid.Parse("2af1788b-3dd5-404b-a3d6-16530295425a");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = LawfulNeutral.ID,
                Name = "Abadar", 
                Description = "The Master of the First Vault holds sway over cities, the law, merchants, and wealth. Abadar seeks to bring civilization to the wild places of the world, encourages adherence to law, and promotes commerce and trade within civilization. He also encourages cooperation among the various ancestries.",
                Edicts = "Bring civilization to the frontiers, earn wealth through hard work and trade, follow the rule of law.",
                Anathema = "Engage in banditry or piracy, steal, undermine a law-abiding court.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Society.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Cities.ID;
            yield return Earth.ID;
            yield return Travel.ID;
            yield return Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulGood.ID;
            yield return LawfulNeutral.ID;
            yield return LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("025c196d-484a-449c-8b97-55112bb31a1f"),
                SourceId = CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
