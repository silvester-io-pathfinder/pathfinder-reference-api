using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class DubiousKnowledgeFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("fffc0274-b5cd-428f-8144-a7d8b01f5986"),
                Name = "Dubious Knowledge",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("28d7b87a-55a3-48f3-9071-ab3e1600f129"), Text = "You’re a treasure trove of information, but not all of it comes from reputable sources. When you fail (but don’t critically fail) a Recall Knowledge check using any skill, you learn a bit of true knowledge and a bit of erroneous knowledge, but you don’t have any way to differentiate which is which." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new RecallKnowledgePrerequisite { Id = Guid.Parse("a85e2c74-32bb-42f4-b3bd-dd42dd68fdc0"), RequiresAssurance = false, RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
