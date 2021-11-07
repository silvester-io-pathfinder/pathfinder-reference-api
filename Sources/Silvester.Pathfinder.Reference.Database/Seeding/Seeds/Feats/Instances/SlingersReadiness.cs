using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlingersReadiness : Template
    {
        public static readonly Guid ID = Guid.Parse("4469ae8e-543c-4732-a7c7-efa03d2a8d81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slinger's Readiness",
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
            yield return new TextBlock { Id = Guid.Parse("66c52149-ead6-412b-b9e3-56cff247844e"), Type = TextBlockType.Text, Text = "You’ve learned a gunslinger’s tricks for staking out your territory in a fight. You gain the initial deed for the way you selected with Gunslinger’s Dedication." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("17163124-8529-4e13-aa92-a41b042d2500"), Feats.Instances.GunslingerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("098b78c0-e799-4264-a901-6a0269e6ed57"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
