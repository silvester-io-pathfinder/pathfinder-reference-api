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
    public class ZonKuthon : Template
    {
        public static readonly Guid ID = Guid.Parse("67d15e7b-a6b4-4907-8ce0-9253a8cf3c2e");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = LawfulEvil.ID,
                Name = "Zon-Kuthon", 
                Description = "The Midnight Lord is god of darkness, envy, loss, and pain. Once a god of art, beauty, and music, like Shelyn, he returned from a sojourn in the dark spaces between the planes horribly changed.",
                Edicts = "Bring pain to the world, mutilate your body.",
                Anathema = "Create permanent or long-lasting sources of light, provide comfort to those who suffer.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Ambition.ID;
            yield return Darkness.ID;
            yield return Destruction.ID;
            yield return Pain.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulNeutral.ID;
            yield return LawfulEvil.ID;
            yield return NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d9c4ab7-80a3-43bd-a585-40ec60dc9806"),
                SourceId = CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
