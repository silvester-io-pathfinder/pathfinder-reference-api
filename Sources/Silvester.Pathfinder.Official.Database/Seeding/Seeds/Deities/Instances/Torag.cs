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
    public class Torag : Template
    {
        public static readonly Guid ID = Guid.Parse("c5e961a7-75ec-42cd-8cce-b455b7a75736");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = LawfulGood.ID,
                Name = "Torag", 
                Description = "The dwarven deity called the Father of Creation is god of the forge, protection, and strategy. Though most widely worshipped by dwarves, those who treasure crafting and creation also follow Torag.",
                Edicts = "Be honorable and forthright, keep your word, respect the forge, serve your people.",
                Anathema = "Tell lies or cheat someone, intentionally create inferior works, show mercy to the enemies of your people.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Crafting.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Creation.ID;
            yield return Earth.ID;
            yield return Family.ID;
            yield return Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulGood.ID;
            yield return LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cdbd3d0-14ef-44c5-883a-ffa09891f018"),
                SourceId = CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
