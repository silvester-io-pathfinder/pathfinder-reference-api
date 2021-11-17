using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeceptiveWorship : Template
    {
        public static readonly Guid ID = Guid.Parse("8ae7a55d-7e56-4fdf-8edd-d7692ffc9aa0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deceptive Worship",
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
            yield return new TextBlock { Id = Guid.Parse("71cd461c-4288-41ea-9bd1-60c3d71def2c"), Type = TextBlockType.Text, Text = "Members of your cult frequently pass themselves off as worshippers of other religions. You can use Occultism instead of Deception to (action: Impersonate) a typical worshipper of another faith or to (action: Lie) specifically to claim you are a member of the faith you are (action: Impersonating | Impersonate). You still need to use the Deception skill to (action: Impersonate) a specific worshipper or to perform other deceptive actions, such as attempting to (action: Lie) about any other matter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("82441164-0f95-4b3f-90fa-545747360497"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("efeb9dff-d403-4490-85f5-03765de1c6ae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
