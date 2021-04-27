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
    public class Irori : AbstractDeityTemplate
    {
        public static readonly Guid ID = Guid.Parse("0415c874-8745-4a38-8e17-41b1e5c8d663");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = LawfulNeutral.ID,
                Name = "Irori", 
                Description = "When the Master of Masters attained true enlightenment, he became a god of history, knowledge, and self-perfection. Irori promotes discipline and teaches that one who can master themself finds the greatest benefits the world can provide.",
                Edicts = "Be humble; help others perfect themselves; hone your body, mind, and spirit to a more perfect state; practice discipline.",
                Anathema = "Become addicted to a substance, destroy an important historical text, repeatedly fail to maintain self-control.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Knowledge.ID;
            yield return Might.ID;
            yield return Perfection.ID;
            yield return Truth.ID;
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
                Id = Guid.Parse("d3a8e131-0e4a-471f-8309-cfc1c526639d"),
                SourceId = CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
