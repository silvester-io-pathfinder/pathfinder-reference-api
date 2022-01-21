using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MomentOfClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("f531a2b0-e1cf-4d68-af01-bdd6b8df7d15");

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
            yield return new TextBlock { Id = Guid.Parse("fdeb74b7-70c0-4582-8575-1e1b19b42131"), Type = TextBlockType.Text, Text = "You push back your rage for a moment in order to think clearly. Until the end of this turn, you can use actions with the (trait: concentrate) trait even if those actions don't have the (trait: rage) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5ab239f-1fd4-4aca-b04c-200111f05f31"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}