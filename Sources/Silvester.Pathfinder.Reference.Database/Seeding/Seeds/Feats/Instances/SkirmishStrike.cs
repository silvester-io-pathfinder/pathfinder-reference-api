using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkirmishStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("7164adab-fbbb-497f-8368-6777bb8a2479");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skirmish Strike",
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
            yield return new TextBlock { Id = Guid.Parse("0de97219-d92d-4c4e-b762-39ff0ab0637a"), Type = TextBlockType.Text, Text = "Your feet and weapon move in tandem. Either (action: Step) and then (action: Strike), or (action: Strike) and then (action: Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7f2fb005-86a3-4467-a016-ef2c268968c9"), Feats.Instances.DrowShootistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3b68e67-7916-4b03-afa3-7f7ddbb1201a"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
