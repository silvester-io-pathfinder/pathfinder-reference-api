using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FavoredEnemy : Template
    {
        public static readonly Guid ID = Guid.Parse("02fda96d-439f-4fb7-8290-d19c2be14faf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Favored Enemy",
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
            yield return new TextBlock { Id = Guid.Parse("afe8f026-be36-4450-9f8f-519c693ed84c"), Type = TextBlockType.Text, Text = "You have studied a specific type of wild creature and can hunt it more easily. When you gain this feat, choose animals, beasts, dragons, or both fungi and plants as your favored enemy. When you roll initiative and can see an enemy that belongs to the chosen category, you can (action: Hunt Prey) as a free action, designating that enemy." };
            yield return new TextBlock { Id = Guid.Parse("4930a22c-c769-4bfb-a776-4b1c02a89f07"), Type = TextBlockType.Text, Text = "You can use this free action even if you haven’t identified the creature yet with (action: Recall Knowledge). The benefit doesn’t apply against favored enemies disguised as other creatures, and the GM determines whether it applies against a creature disguised as a favored enemy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c3ae550-3931-4542-b4d2-040cb79f0e31"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
