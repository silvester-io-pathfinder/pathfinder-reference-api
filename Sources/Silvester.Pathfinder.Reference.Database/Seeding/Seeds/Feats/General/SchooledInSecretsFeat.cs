using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class SchooledInSecretsFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("ad11834f-bb08-4920-9602-6300a7ec1157");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Schooled in Secrets",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30876b0c-efaa-4e14-9f73-ffb65f6d4298"), Type = TextBlockType.Text, Text = "You notice the signs and symbols that members of mystery cults and other secret societies use to declare their affiliation to fellow members. You can use Occultism in place of Diplomacy to Gather Information about such groups. If you belong to a secret cult, lodge, sect, or similar organization, you automatically recognize members of your group unless they are specifically attempting to conceal their presence from you." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("9cc8842c-2060-48d8-9cfb-52d7558e23af"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("938b0835-6f9d-494f-882e-db34ba64cc50"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 208
            };
        }
    }
}
