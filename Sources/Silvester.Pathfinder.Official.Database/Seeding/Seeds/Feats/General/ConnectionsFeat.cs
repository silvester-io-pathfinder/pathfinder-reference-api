using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class ConnectionsFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("a38f19f2-3b2d-4907-8425-d71dc351e8df"),
                Name = "Connections",
                Level = 2
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8327dfe8-9bc4-40ab-8459-51ce05d11517"), Type = Utilities.Text.TextBlockType.Text, Text = "You have social connections you can leverage to trade favors or meet important people. When you’re in an area with connections (typically a settlement where you’ve spent downtime building connections, or possibly another area in the same nation), you can attempt a Society check to arrange a meeting with an important political figure or ask for a favor in exchange for a later favor of your contact’s choice. The GM decides the DC based on the difficulty of the favor and the figure’s prominence." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c7af13d6-533f-4d31-b058-a16371e5f7fc"), RequiredSkillId = seeder.GetSkill("Society"), RequiredProficiencyId = seeder.GetProficiency("Expert") };
            yield return new FeatPrerequisite { Id = Guid.Parse("ee3c490c-28f3-410a-bce3-c7de7c756ff8"), RequiredFeatId = Guid.Parse("5c26de36-847d-4a16-8871-0a2016fdfacc") };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Uncommon";
            yield return "General";
            yield return "Skill";
        }
    }
}
