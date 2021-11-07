using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiverseRecognition : Template
    {
        public static readonly Guid ID = Guid.Parse("3e49503f-f300-44f8-8d65-3af2c237a1a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diverse Recognition",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You successfully Recall Knowledge about a creature you can see, using a skill in which you are a master.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0bbf8537-a814-47dc-a354-4d416f86acba"), Type = TextBlockType.Text, Text = "Your Pathfinder training allows you to quickly size up numerous threats. Attempt to (action: Recall Knowledge) against a different kind of creature you can see using the same skill. You must still meet the requirements to attempt this check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("50f8a5ac-7145-481d-b0f8-b817b7856406"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("347bd02b-ae40-4d31-a78c-ddf34ea82ce2"), Proficiencies.Instances.Master.ID, requiresAssurance: false);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("613707aa-61e7-4085-aaa9-f613ac7d7e77"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
