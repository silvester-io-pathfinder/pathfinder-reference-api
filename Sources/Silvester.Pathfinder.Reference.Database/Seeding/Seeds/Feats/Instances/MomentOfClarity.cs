using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MomentOfClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("fb1060e2-90e3-422a-9c3d-366293f77ffc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Moment of Clarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58d2919d-7d42-4159-a077-90942e997ee5"), Type = TextBlockType.Text, Text = "You push back your rage for a moment in order to think clearly. Until the end of this turn, you can use actions with the (trait: concentrate) trait even if those actions don’t have the (trait: rage) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4bc4538-b5e9-4f82-83f0-010de20bb91c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
