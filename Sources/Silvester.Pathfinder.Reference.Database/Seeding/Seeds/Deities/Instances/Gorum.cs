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
    public class Gorum : Template
    {
        public static readonly Guid ID = Guid.Parse("d274f8e2-3806-434d-99d1-6f3002baf280");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = ChaoticNeutral.ID,
                Name = "Gorum", 
                Description = "Soldiers call out prayers to Our Lord in Iron, god of battle, strength, and weapons. Gorum emphasizes strength and power, encouraging his followers to seek out war and combat as the ultimate way to worship him.",
                Edicts = "Attain victory in fair combat, push your limits, wear armor in combat.",
                Anathema = "Kill prisoners or surrendering foes, prevent conflict through negotiation, win a battle through underhanded tactics or indirect magic.",
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
            yield return Confidence.ID;
            yield return Destruction.ID;
            yield return Might.ID;
            yield return Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return ChaoticNeutral.ID;
            yield return ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("998a8f27-aff1-4e34-abf4-983f353b7e14"),
                SourceId = CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
