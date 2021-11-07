using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchooledInSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("7e3043bf-382d-4756-9384-ad9638803812");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Schooled in Secrets",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8e17bfe-757e-4c85-b7d1-ddc42d23ef2a"), Type = TextBlockType.Text, Text = "You notice the signs and symbols that members of mystery cults and other secret societies use to declare their affiliation to fellow members. You can use Occultism in place of Diplomacy to (action: Gather Information) about such groups. If you belong to a secret cult, lodge, sect, or similar organization, you automatically recognize members of your group unless they are specifically attempting to conceal their presence from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c23308e4-1a9f-4a4c-b37b-8073a23f7d58"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9833109-9329-4da1-b5a6-a79ca30a42a3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
