using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlchemicalScholar : Template
    {
        public static readonly Guid ID = Guid.Parse("b853a13f-740d-4d6b-a7ff-daa522cd2166");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Alchemical Scholar",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain into or out of this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71f40b96-78a1-4701-a152-77fafcccb43c"), Type = TextBlockType.Text, Text = "You learn formulas more easily. You gain four common 1st-level alchemical formulas when you take this feat, and each time you gain a level, you gain a common alchemical formula of that level. You still need (Feat: Alchemical Crafting) to (Action: Craft) alchemical items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5b871f5-d584-4ef9-ad81-5da9d238773f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
