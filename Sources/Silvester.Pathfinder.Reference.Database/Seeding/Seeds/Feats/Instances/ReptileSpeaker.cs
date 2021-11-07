using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReptileSpeaker : Template
    {
        public static readonly Guid ID = Guid.Parse("deebfe57-57cd-48b9-a515-64fa386f9518");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reptile Speaker",
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
            yield return new TextBlock { Id = Guid.Parse("c7382b2c-9235-4e96-bc47-c146a344553a"), Type = TextBlockType.Text, Text = "You hear the sounds of reptiles as language. You can ask questions of, receive answers from, and use the Diplomacy skill with animals that are reptiles (the GM determines which animals count as reptiles)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9b9e1e6-8252-49d8-a3eb-78c7e4e22237"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
