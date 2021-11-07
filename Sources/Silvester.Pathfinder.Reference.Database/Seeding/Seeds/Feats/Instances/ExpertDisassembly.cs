using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertDisassembly : Template
    {
        public static readonly Guid ID = Guid.Parse("09a6dffb-0801-4bc4-b8a3-3729499be675");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Disassembly",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed94d65d-76f5-4933-8885-2b5acbc9d84e"), Type = TextBlockType.Text, Text = "You can apply the same techniques you use to reverse engineer objects to disable them. You can use Crafting instead of Thievery to (action: Disable a Device) or (action: Pick a Lock)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("655f6947-b37c-49d0-9b6e-722f25d17592"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveSpecificFeat(Guid.Parse("58019ca7-a153-4fbc-8ac3-ed528beeefc6"), Feats.Instances.ScroungerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce2baebb-fd26-4061-9263-642d8238d204"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
