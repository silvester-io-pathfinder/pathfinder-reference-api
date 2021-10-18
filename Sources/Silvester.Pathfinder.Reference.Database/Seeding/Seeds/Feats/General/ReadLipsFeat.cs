using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ReadLipsFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("ad4fe73a-0518-46c1-bfee-130d1b2053ab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read Lips",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe9c688e-04a1-4e87-bfea-ad1d9224efd5"), Type = Utilities.Text.TextBlockType.Text, Text = "You can read lips of others nearby who you can clearly see. When you’re at your leisure, you can do this automatically. In encounter mode or when attempting a more difficult feat of lipreading, you’re fascinated and flat-footed during each round in which you focus on lip movements, and you must succeed at a Society check (DC determined by the GM) to successfully read someone’s lips. In either case, the language read must be one that you know." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("f43e37fd-33cb-451e-89c2-a9e45e351308"), RequiredSkillId = Skills.Instances.Society.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("ecccecf5-f819-461d-93f9-68545168448b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 265
            };
        }
    }
}
