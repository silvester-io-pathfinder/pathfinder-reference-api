using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class AutomaticKnowledgeFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("ca8d59e8-f938-4ffb-9890-9bed87134d5b"),
                Name = "Automatic Knowledge",
                Level = 2,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times, choosing a different skill each time. You can use Automatic Knowledge with any skills you have chosen, but you can still use Automatic Knowledge only once per round."
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("f3025adc-d289-42fc-b072-64fb3a523a45"), Text = "You know basic facts off the top of your head. Choose a skill you’re an expert in that has the Recall Knowledge action and for which you have the Assurance feat. You can use the Recall Knowledge action with that skill as a free action once per round. If you do, you must use Assurance on the skill check." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new RecallKnowledgePrerequisite { Id = Guid.Parse("67a960ad-7744-4ad9-a3b2-1f9445e52e69"), RequiresAssurance = true, RequiredProficiencyId = seeder.GetProficiency("Expert") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
