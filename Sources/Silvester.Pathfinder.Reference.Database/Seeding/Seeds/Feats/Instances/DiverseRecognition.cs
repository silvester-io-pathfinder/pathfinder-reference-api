using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiverseRecognition : Template
    {
        public static readonly Guid ID = Guid.Parse("0afda4fb-a0dc-4362-92bf-861ac22f7428");

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
            yield return new TextBlock { Id = Guid.Parse("d7240520-f445-4826-b7ca-0e9baa9398e3"), Type = TextBlockType.Text, Text = "Your Pathfinder training allows you to quickly size up numerous threats. Attempt to (action: Recall Knowledge) against a different kind of creature you can see using the same skill. You must still meet the requirements to attempt this check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e0ad4275-0939-43df-b93a-54b7752ba391"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("ccb3b63c-8e70-4a5e-8807-486f98174cc5"), Proficiencies.Instances.Master.ID, requiresAssurance: False);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ad651fb-7757-4dae-bbe3-81181248bb1d"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
