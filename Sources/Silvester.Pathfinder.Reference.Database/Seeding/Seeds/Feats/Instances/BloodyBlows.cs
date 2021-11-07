using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodyBlows : Template
    {
        public static readonly Guid ID = Guid.Parse("44a92b89-8c58-4922-b720-58f52ed3e15b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloody Blows",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b74180a3-846d-4d38-a3ed-b55014574783"), Type = TextBlockType.Text, Text = "Your lethal unarmed attacks leave bloody gouges or cause severe internal bleeding. When you critically hit with a (action: Strike) using an unarmed attack that isn&#39;t (trait: nonlethal), the target takes 1d4 persistent bleed damage. This can be because you&#39;re taking the penalty to use a fist for a lethal attack or because you have an unarmed attack without the (trait: nonlethal) trait due to (feat: Iron Fists), (feat: Tusks), or a similar ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95d0233d-8a8a-4c36-9825-d190422fee45"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
