using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecognizeThreat : Template
    {
        public static readonly Guid ID = Guid.Parse("0b8713aa-fe38-43e2-bb43-2b3a94bcf912");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recognize Threat",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your first turn of an encounter begins, and you can see a creature.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f78c3f1-4a47-4f6b-9f8a-1bbced890229"), Type = TextBlockType.Text, Text = "You quickly assess the threat so you can relay the information to your team. Attempt a (action: Recall Knowledge) check against the triggering creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("49878aef-72ba-49a8-9b7a-fa74110def78"), Proficiencies.Instances.Master.ID, requiresAssurance: False);
            builder.HaveSpecificFeat(Guid.Parse("28bee8b3-cbce-4c6f-b623-dbea3f521a90"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2caca448-3210-47a8-a17e-fcc1ee9b83ea"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
