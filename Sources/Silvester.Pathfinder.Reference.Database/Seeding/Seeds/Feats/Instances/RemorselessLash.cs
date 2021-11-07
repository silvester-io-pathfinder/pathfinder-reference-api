using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RemorselessLash : Template
    {
        public static readonly Guid ID = Guid.Parse("9cab3185-0253-4c49-b43a-36e26953bf78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remorseless Lash",
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
            yield return new TextBlock { Id = Guid.Parse("59507a93-3e52-44b7-a85d-0f758d9838c0"), Type = TextBlockType.Text, Text = "You’re skilled at beating a foe when their morale is already breaking. When you succeed at a melee weapon (Action: Strike) against a frightened foe, that foe can’t reduce their frightened condition below 1 until the beginning of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2aba5e4-8471-42d3-ab98-4ad87c59528f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
