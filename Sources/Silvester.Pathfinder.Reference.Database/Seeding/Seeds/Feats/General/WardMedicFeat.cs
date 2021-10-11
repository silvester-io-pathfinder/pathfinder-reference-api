using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class WardMedicFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("b5d31ebb-d361-4780-93c5-324bfd3c39b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Medic",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8156a63f-dd8b-45e7-af35-fc4e6552a587"), Type = Utilities.Text.TextBlockType.Text, Text = "You’ve studied in large medical wards, treating several patients at once and tending to all their needs. When you use Treat Disease or Treat Wounds, you can treat up to two targets. If you’re a master in Medicine, you can treat up to four targets, and if you’re legendary, you can treat up to eight targets." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("c999f2ff-0c41-4fa7-99fb-29c166253148"), RequiredSkillId = Skills.Instances.Medicine.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
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
                Id = Guid.Parse("1124da0d-456c-432c-a2d1-93e60084d654"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 269
            };
        }
    }
}
