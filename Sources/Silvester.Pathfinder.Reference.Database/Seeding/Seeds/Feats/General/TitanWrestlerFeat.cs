using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class TitanWrestlerFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("fee17526-90f5-401c-bdec-d084f40852a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Titan Wrestler",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a652425-e8de-4a6d-83e8-523505d4f747"), Type = Utilities.Text.TextBlockType.Text, Text = "You can attempt to Disarm, Grapple, Shove, or Trip creatures up to two sizes larger than you, or up to three sizes larger than you if you’re legendary in Athletics." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("063735a0-a7f9-4165-aa97-74c04557ae1f"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID};
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
                Id = Guid.Parse("9b31d583-f2c4-4501-81cd-de29d8d6e784"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 268
            };
        }
    }
}
