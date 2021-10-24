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
    public class Calistria : Template
    {
        public static readonly Guid ID = Guid.Parse("39e8ec90-6039-446c-969e-0957dc64cc6e");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = ChaoticNeutral.ID,
                Name = "Calistria", 
                Description = "The mischievous goddess known as the Savored Sting extols the virtues of lust, revenge, and trickery. Though Calistria is most widely worshipped by elves, members of many other ancestries follow her as well.",
                Edicts = "Pursue your personal freedom, seek hedonistic thrills, take revenge.",
                Anathema = "Become too consumed by love or a need for revenge, let a slight go unanswered.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Deception.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Pain.ID;
            yield return Passion.ID;
            yield return Secrecy.ID;
            yield return Trickery.ID;
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
                Id = Guid.Parse("ea1cac98-fca5-4046-bdde-83bf16bda45a"),
                SourceId = CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
