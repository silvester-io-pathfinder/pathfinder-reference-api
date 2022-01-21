using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnduranceOfTheRootedTree : Template
    {
        public static readonly Guid ID = Guid.Parse("07f16b9d-b6cc-4547-98b4-b3b7f5164d09");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Endurance of the Rooted Tree",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fcce4234-610d-4f51-b82c-5b4ef39e81a7"), Type = TextBlockType.Text, Text = "Just as the Vale of Aroden retains light and life despite inhospitable surroundings, you can sustain yourself regardless of your environment. You don't need to eat, drink, or breathe. In addition, you can cast the (spell: wholeness of body) ki spell almost effortlessly. You can cast it as a free action that triggers at the start of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3b453302-d3be-4bf2-b257-51112586cbef"), Feats.Instances.WholenessOfBody.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13f0ebb0-e901-490a-9c6d-ed48a5d075e3"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
