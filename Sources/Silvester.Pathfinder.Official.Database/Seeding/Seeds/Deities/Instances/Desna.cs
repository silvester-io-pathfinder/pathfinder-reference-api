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
    public class Desna : AbstractDeityTemplate
    {
        public static readonly Guid ID = Guid.Parse("8c8ec43f-d34f-4f82-806f-8c5c2db099c4");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = ChaoticGood.ID,
                Name = "Desna", 
                Description = "The kindly Song of the Spheres presides over dreams, luck, stars, and travelers. An ancient goddess, Desna delights in freedom and mystery, and she encourages her followers to do the same.",
                Edicts = "Aid fellow travelers, explore new places, express yourself through art and song, find what life has to offer.",
                Anathema = "Cause fear or despair, cast nightmare or use similar magic to corrupt dreams, engage in bigoted behavior.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Dreams.ID;
            yield return Luck.ID;
            yield return Moon.ID;
            yield return Travel.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return NeutralGood.ID;
            yield return ChaoticGood.ID;
            yield return ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d034452-80cd-4cac-aa96-819317a3cc94"),
                SourceId = CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
