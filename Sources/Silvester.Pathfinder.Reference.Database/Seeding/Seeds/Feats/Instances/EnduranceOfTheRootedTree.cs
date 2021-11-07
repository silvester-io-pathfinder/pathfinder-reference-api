using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnduranceOfTheRootedTree : Template
    {
        public static readonly Guid ID = Guid.Parse("000ccd79-b5a4-4f44-bbcf-4cccc55a4f1d");

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
            yield return new TextBlock { Id = Guid.Parse("df07e9bb-a707-4d1c-8def-f178c5378ff0"), Type = TextBlockType.Text, Text = "Just as the Vale of Aroden retains light and life despite inhospitable surroundings, you can sustain yourself regardless of your environment. You don’t need to eat, drink, or breathe. In addition, you can cast the (spell: wholeness of body) ki spell almost effortlessly. You can cast it as a free action that triggers at the start of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f01238de-ef55-43ac-b8c7-f5dfd394a85a"), Feats.Instances.WholenessOfBody.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("856fbd1d-57f0-4930-b40a-22320c80f86f"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
