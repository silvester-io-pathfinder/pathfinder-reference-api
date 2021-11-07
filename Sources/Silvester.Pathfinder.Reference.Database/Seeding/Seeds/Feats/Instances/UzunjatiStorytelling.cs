using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UzunjatiStorytelling : Template
    {
        public static readonly Guid ID = Guid.Parse("eb913c78-5105-44ba-91e1-d8bc0a216d52");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uzunjati Storytelling",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1cd7551-84f5-4f84-93bc-46ad60c7026f"), Type = TextBlockType.Text, Text = "You tell a quick story or begin telling a longer tale. This is most useful when you want to prove your scholarly credibility or impress someone quickly. Roll a check with a skill that can be used to (action: Recall Knowledge) in which you have expert proficiency, using the result entry for the (action: Perform) action. Like (action: Performing | Perform), storytelling rarely has an effect on its own, but it might influence the DCs of subsequent Diplomacy checks against the observers – or even change their attitudes – if the GM sees fit. This action is not a performance and cannot be used in place of anything that requires you to (action: Perform)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("44cfcac0-7f34-4874-9a01-e97285dd9821"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("1b9ac7cb-7ee9-4945-afad-7bb9767babec"), "Uzunjati affiliation");
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("e2849378-8005-4187-9678-7d33724276f8"), Proficiencies.Instances.Master.ID, requiresAssurance: false);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cf35dfd-8215-4ae1-8150-de2dac35178c"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
