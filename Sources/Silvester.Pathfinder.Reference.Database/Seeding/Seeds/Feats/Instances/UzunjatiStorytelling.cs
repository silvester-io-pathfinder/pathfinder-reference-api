using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UzunjatiStorytelling : Template
    {
        public static readonly Guid ID = Guid.Parse("9be18e0e-84af-4148-9b17-2f55609bce1e");

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
            yield return new TextBlock { Id = Guid.Parse("c92c6bc7-b71b-4cfd-b998-ced1f8551879"), Type = TextBlockType.Text, Text = "You tell a quick story or begin telling a longer tale. This is most useful when you want to prove your scholarly credibility or impress someone quickly. Roll a check with a skill that can be used to (action: Recall Knowledge) in which you have expert proficiency, using the result entry for the (action: Perform) action. Like (action: Performing | Perform), storytelling rarely has an effect on its own, but it might influence the DCs of subsequent Diplomacy checks against the observers – or even change their attitudes – if the GM sees fit. This action is not a performance and cannot be used in place of anything that requires you to (action: Perform)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("29cf145b-db39-424b-991e-d13a067fdbbe"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("c98a3004-2ac9-4965-a86b-98ce0533292e"), "Uzunjati affiliation");
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("42a62fce-0911-4e6b-a001-d05a9f6566b9"), Proficiencies.Instances.Master.ID, requiresAssurance: False);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("532a91b1-691e-4dd2-8206-0c1274914c36"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
