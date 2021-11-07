using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TangleOfBattle : Template
    {
        public static readonly Guid ID = Guid.Parse("1ae7338a-15ec-4b8a-8aa3-1f1dde74e969");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tangle of Battle",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You critically hit an adjacent enemy.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a18bc8f-a340-43bf-806e-9487a8ff884c"), Type = TextBlockType.Text, Text = "Your incredibly vicious (action: Strike) pulls you right in close, giving you the opportunity to grab your foe. Attempt to (action: Grapple) the triggering enemy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4df1fad0-98be-4977-b504-a1516f86d34d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
