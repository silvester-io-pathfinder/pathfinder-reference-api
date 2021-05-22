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
    public class Shelyn : Template
    {
        public static readonly Guid ID = Guid.Parse("b4a8671f-6c2a-4e02-911d-f9152132ef83");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = NeutralGood.ID,
                Name = "Shelyn", 
                Description = "The Eternal Rose is the goddess of art, beauty, love, and music. She seeks to one day redeem her corrupted brother, Zon-Kuthon. Shelyn promotes peace and love, and she encourages her followers to create beauty in a sometimes dark world.",
                Edicts = "Be peaceful, choose and perfect an art, lead by example, see the beauty in all things.",
                Anathema = "Destroy art or allow it to be destroyed, unless saving a life or pursuing greater art; refuse to accept surrender.",
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Crafting.ID;
            yield return Performance.ID;
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Creation.ID;
            yield return Family.ID;
            yield return Passion.ID;
            yield return Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulGood.ID;
            yield return NeutralGood.ID;
            yield return ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00e5ec2c-1491-4f06-b8a2-97d4fa419e58"),
                SourceId = CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
