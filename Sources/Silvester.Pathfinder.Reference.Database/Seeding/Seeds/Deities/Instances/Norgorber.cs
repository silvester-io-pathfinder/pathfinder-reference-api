using Silvester.Pathfinder.Reference.Database.Models;
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
    public class Norgorber : Template
    {
        public static readonly Guid ID = Guid.Parse("08d4de0c-6e87-43a9-ac23-abeab99e73e4");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = NeutralEvil.ID,
                Name = "Norgorber", 
                Description = "The god of greed, murder, poison, and secrets has four aspects: Blackfingers, ally of alchemists and poisoners; the murderous Father Skinsaw; the thieving Gray Master; and the secretive Reaper of Reputation.",
                Edicts = "Keep your true identity secret, sacrifice anyone necessary, take every advantage in a fight, work from the shadows.",
                Anathema = "Allow your true identity to be connected to your dark dealings, share a secret freely, show mercy.",
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Death.ID;
            yield return Secrecy.ID;
            yield return Trickery.ID;
            yield return Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulEvil.ID;
            yield return NeutralEvil.ID;
            yield return ChaoticEvil.ID;
            yield return TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4edda98-8fa7-41ab-92b4-a426d661c974"),
                SourceId = CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
