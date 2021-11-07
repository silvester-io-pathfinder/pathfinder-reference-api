using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PositioningAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("4d511d8f-65ab-4536-8530-eee793bf472f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Positioning Assault",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e100dbfa-6c07-4258-8f77-cbc9b95b3c1e"), Type = TextBlockType.Text, Text = "With punishing blows, you force your opponent into position." };
            yield return new TextBlock { Id = Guid.Parse("c1c2d1ee-ae99-4692-bb31-4b29c2094dfb"), Type = TextBlockType.Text, Text = "Make a (Action: Strike) with the required weapon. If you hit, you move the target 5 feet into a space in your reach. This follows the forced movement rules found on page 475." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4c6a7e3-dc41-41a0-af39-2c078b0d1d4f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
