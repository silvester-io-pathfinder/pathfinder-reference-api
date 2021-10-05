using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class NimbleCrawlFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("df3e0135-e1de-4b1f-a580-19f521c5f328");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nimble Crawl",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("614b8596-39fa-4006-903f-355857fc1e2d"), Type = Utilities.Text.TextBlockType.Text, Text = "You can Crawl incredibly swiftly—up to half your Speed, rather than 5 feet. If you’re a master in Acrobatics, you can Crawl at full Speed, and if you’re legendary, you aren’t flat-footed while prone." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("8f8b340d-5aad-41ac-a4f7-160fa57e0dff"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
