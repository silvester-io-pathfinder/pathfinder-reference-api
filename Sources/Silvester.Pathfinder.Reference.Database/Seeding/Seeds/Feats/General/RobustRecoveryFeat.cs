using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class RobustRecoveryFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("2107ba8d-4766-4434-b23e-fe90d9837b02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Robust Recovery",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b465363-62e4-41bb-a073-96f9423c8c4e"), Type = Utilities.Text.TextBlockType.Text, Text = "You learned folk medicine to help recover from diseases and poison, and using it diligently has made you especially resilient. When you Treat a Disease or a Poison, or someone else uses one of these actions on you, increase the circumstance bonus granted on a success to +4, and if the result of the patient’s saving throw is a success, the patient gets a critical success." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("63790dc9-79b8-48b9-91c3-351c3498de27"), RequiredSkillId = Skills.Instances.Medicine.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
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
                Id = Guid.Parse("e08f887b-3c98-41a6-b105-73441fdb2fbd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 266
            };
        }
    }
}
