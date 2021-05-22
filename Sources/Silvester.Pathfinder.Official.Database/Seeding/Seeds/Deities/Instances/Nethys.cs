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
    public class Nethys : Template
    {
        public static readonly Guid ID = Guid.Parse("133e4a71-2a14-4f2e-bd41-d6ee0bb7b598");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = TrueNeutral.ID,
                Name = "Nethys", 
                Description = "The All-Seeing Eye, god of magic, has a dualistic nature of destruction and preservation; his ability to witness all things has shattered his mind.",
                Edicts = "Seek out magical power and use it.",
                Anathema = "Pursue mundane paths over magical ones.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Destruction.ID;
            yield return Knowledge.ID;
            yield return Magic.ID;
            yield return Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return NeutralGood.ID;
            yield return LawfulNeutral.ID;
            yield return TrueNeutral.ID;
            yield return ChaoticEvil.ID;
            yield return NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72f3e707-fb54-4a22-a204-c9e9cd2a14ba"),
                SourceId = CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
