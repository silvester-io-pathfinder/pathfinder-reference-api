using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicFury : Template
    {
        public static readonly Guid ID = Guid.Parse("20294f4b-15db-40c7-a543-532f2a43a7b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Fury",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69b332ac-e3b2-4c89-9850-d5fde120c076"), Type = TextBlockType.Text, Text = "You gain a 1st- or 2nd-level barbarian feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc4795ab-1a71-4acf-9f93-ef744d24cde4"), Feats.Instances.BarbarianDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f302d36-cd92-41f7-bffd-a8a59c3ca672"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
