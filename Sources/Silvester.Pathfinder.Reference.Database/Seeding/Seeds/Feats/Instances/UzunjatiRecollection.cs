using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UzunjatiRecollection : Template
    {
        public static readonly Guid ID = Guid.Parse("10b3eb35-d23d-494e-87e7-9bad9ca3d9ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uzunjati Recollection",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09e88431-16df-4f0c-8cd4-7fe604dacf5c"), Type = TextBlockType.Text, Text = "You tell a story spontaneously from nearly forgotten facts, delving into your memory and entertaining your audience in the process. (action: Recall Knowledge) with a skill in which you have master proficiency, then use (feat: Uzunjati Storytelling) with the same skill. You gain a +1 circumstance bonus to your skill check for (feat: Uzunjati Storytelling) from the added details." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b1964faf-b5e5-4a54-8544-6cbf791ae442"), Feats.Instances.UzunjatiStorytelling.ID);
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("6a547bce-7a7f-46b1-9cd0-51367afcf300"), Proficiencies.Instances.Master.ID, requiresAssurance: false);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05c5062f-02e7-493a-9adf-bc85d0fec2d9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
