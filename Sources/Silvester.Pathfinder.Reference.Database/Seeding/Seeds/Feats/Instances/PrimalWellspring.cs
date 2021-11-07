using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrimalWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("6e5f4786-a491-463b-aaef-889274dbaa0c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("484469c3-350f-40cc-ae6e-a86331dd6300"), Type = TextBlockType.Text, Text = "Your reservoir of Focus Points is a deep wellspring. If you have spent at least 3 Focus Points since the last time you (Activity: Refocused | Refocus), you recover 3 Focus Points when you (Activity: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0cfe0b66-872d-4cce-9c61-93f79c1bff9c"), Feats.Instances.PrimalFocus.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a191af4-b1e7-476a-8b22-0699664baa01"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
