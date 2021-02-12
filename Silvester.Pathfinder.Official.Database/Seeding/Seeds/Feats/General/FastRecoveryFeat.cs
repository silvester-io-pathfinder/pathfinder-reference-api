using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class FastRecoveryFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("68a98dbf-4a45-4217-a94f-2d0969915d96"),
                Name = "Fast Recovery",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("f95849f0-3bba-430f-b44a-6828c1fbdbe9"), Text = "Your body quickly bounces back from afflictions. You regain twice as many Hit Points from resting. Each time you succeed at a Fortitude save against an ongoing disease or poison, you reduce its stage by 2, or by 1 against a virulent disease or poison. Each critical success you achieve against an ongoing disease or poison reduces its stage by 3, or by 2 against a virulent disease or poison. In addition, you reduce the severity of your drained condition by 2 when you rest for a night instead of by 1." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new StatPrerequisite { Id = Guid.Parse("09e0806b-4107-46a1-a5db-8a7afa301f4d"), RequiredStatValue = 14, RequiredStatId = seeder.GetStat("Constitution") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }
    }
}
