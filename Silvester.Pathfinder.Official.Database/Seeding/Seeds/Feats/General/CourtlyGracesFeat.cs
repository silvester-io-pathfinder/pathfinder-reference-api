using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class CourtlyGracesFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("5c26de36-847d-4a16-8871-0a2016fdfacc"),
                Name = "Courtly Graces",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("38b5844d-0409-48fd-ab87-07bbe0e02f68"), Text = "You were raised among the nobility or have learned proper etiquette and bearing, allowing you to present yourself as a noble and play games of influence and politics. You can use Society to Make an Impression on a noble, as well as with Impersonate to pretend to be a noble if you aren’t one. If you want to impersonate a specific noble, you still need to use Deception to Impersonate normally, and to Lie when necessary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("948b49bd-4759-47e9-924c-f0655daf58bd"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Trained") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
