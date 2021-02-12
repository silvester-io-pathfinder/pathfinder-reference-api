using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LegendaryThiefFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("9ee79ba9-47ac-4cf5-906d-9e88190e8d22"),
                Name = "Legendary Thief",
                Level = 15
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("9dfdb9a4-49d8-41a6-a8ac-2ea5e9e4626c"), Text = "Your ability to Steal defies belief. You can attempt to Steal something that is actively wielded or that would be extremely noticeable or time consuming to remove (like worn shoes or armor). You must do so slowly and carefully, spending at least 1 minute (and significantly longer for items that are normally time consuming to remove, like armor). Throughout this duration you must have some means of staying hidden, such as the cover of darkness or a bustling crowd. You take a –5 penalty to your Thievery check. Even if you succeed, if the item is extremely prominent—like a suit of full plate armor—onlookers will quickly notice it’s gone after you steal it." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("fbc70e79-8d3d-4b12-9fe2-f60f7a3fe5f3"), RequiredSkillId = seeder.GetSkill("Thievery"), RequiredProficiencyId = seeder.GetProficiency("Legendary") };
            yield return new FeatPrerequisite { Id = Guid.Parse("493d56f0-7760-44fd-948c-20bad99cdf33"), RequiredFeatId = PickpocketFeat.ID };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
            yield return "Skill";
        }
    }
}
