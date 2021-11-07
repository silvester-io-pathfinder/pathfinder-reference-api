using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MatureTrainedCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("b48c20fb-050c-4969-9ddf-252f21fb10db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mature Trained Companion",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cab7052-4499-4d7e-9dd9-ff9e1708d57b"), Type = TextBlockType.Text, Text = "Your animal companion grows up, becoming a mature animal companion. Increase its proficiency rank in Performance to expert instead of one of the three skill increases for mature. It gains the (feat: Mesmerizing Performance) advanced maneuver, rather than the normal advanced maneuver for its type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("703136a9-f249-4498-80b6-b80982e1c5af"), Feats.Instances.AnimalTrainerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("715fdcd4-8943-42b7-a06f-529e9743b78b"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
