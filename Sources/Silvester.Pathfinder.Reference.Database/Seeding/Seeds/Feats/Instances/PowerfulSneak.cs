using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PowerfulSneak : Template
    {
        public static readonly Guid ID = Guid.Parse("8fc36811-d39e-4bbc-a46b-508e854de9e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Powerful Sneak",
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
            yield return new TextBlock { Id = Guid.Parse("c30c2d92-2627-4caa-9bb1-d988fc1f56fe"), Type = TextBlockType.Text, Text = "You have learned to exploit your enemies’ lowered defenses. When you succeed or critically succeed at a (action: Strike) using your Strength modifier on the attack roll and you would deal sneak attack damage, you can change the additional damage from sneak attack into ordinary damage of the same type as your (action: Strike), rather than precision damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c790103-03a9-4f1b-ac3d-ab746674891a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
