using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecretEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("6ea3e617-c72d-46b3-9164-00631d2bd772");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Secret Eyes",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8b5cf5c-706f-4aef-9313-cd089beb167b"), Type = TextBlockType.Text, Text = "You can call forth an invisible eye to let you peek on secrets. Once per day, you can cast (spell: prying eye) as an innate occult spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8d4bae4-b659-4db0-9f7d-ea78e1049951"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
