using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CooperativeNature : Template
    {
        public static readonly Guid ID = Guid.Parse("fc009616-522f-4468-bf12-6b9da09f6896");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cooperative Nature",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b718acbd-4116-47c3-8b1f-74c840c6e371"), Type = TextBlockType.Text, Text = "The short human life span lends perspective and has taught you from a young age to set aside differences and work with others to achieve greatness. You gain a +4 circumstance bonus on checks to (action: Aid)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db01e28e-ed5d-4d0e-a67f-b62556e23d7c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
