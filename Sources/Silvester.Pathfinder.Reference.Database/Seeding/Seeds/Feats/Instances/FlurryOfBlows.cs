using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlurryOfBlows : Template
    {
        public static readonly Guid ID = Guid.Parse("5907fd15-e862-4a9d-8c5a-a8cf301ef152");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flurry of Blows",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d298b73-e1de-4126-aba8-d89e6c7aba46"), Type = TextBlockType.Text, Text = "Make two unarmed (action: Strikes | Strike). If both hit the same creature, combine their damage for the purpose of resistances and weaknesses. Apply your multiple attack penalty to the (action: Strikes | Strike) normally. As it has the (trait: flourish) trait, you can use Flurry of Blows only once per turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("865c788f-5770-403c-90cd-22f00e6e364a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
