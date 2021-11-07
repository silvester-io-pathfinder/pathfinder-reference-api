using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeceptiveWorship : Template
    {
        public static readonly Guid ID = Guid.Parse("e68f3c58-1b97-4f90-91ca-94719a58ebcb");

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
            yield return new TextBlock { Id = Guid.Parse("9c7419a4-d927-4aef-b7b8-485c0734cd66"), Type = TextBlockType.Text, Text = "Members of your cult frequently pass themselves off as worshippers of other religions. You can use Occultism instead of Deception to (action: Impersonate) a typical worshipper of another faith or to (action: Lie) specifically to claim you are a member of the faith you are (action: Impersonating | Impersonate). You still need to use the Deception skill to (action: Impersonate) a specific worshipper or to perform other deceptive actions, such as attempting to (action: Lie) about any other matter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("66a6e916-7fc7-4ee4-91e1-213cf7f58c22"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19260661-3ba9-41b4-a717-d04b5298781d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
