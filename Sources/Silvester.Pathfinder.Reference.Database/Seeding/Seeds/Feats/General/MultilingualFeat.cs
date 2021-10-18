using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class MultilingualFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8dc95af1-d049-457f-91f8-311ead81336d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multilingual",
                Level = 1,
                Special = "You can select this feat multiple times. Each time, you learn additional languages.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5983317e-3930-45c3-a5b2-d286fd3bf850"), Type = Utilities.Text.TextBlockType.Text, Text = "You easily pick up new languages. You learn two new languages, chosen from common languages, uncommon languages, and any others you have access to. You learn an additional language if you are or become a master in Society and again if you are or become legendary." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("620a99f0-9377-498b-a4cb-590441e62b51"), RequiredSkillId = Skills.Instances.Society.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27d244fd-5c0a-4f25-b3f9-f1f21a118507"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 264
            };
        }
    }
}
