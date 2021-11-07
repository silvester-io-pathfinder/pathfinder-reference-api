using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReptileSpeaker : Template
    {
        public static readonly Guid ID = Guid.Parse("89c67dd2-7219-451d-b9aa-41e63a08a19e");

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
            yield return new TextBlock { Id = Guid.Parse("fbcb25bd-a3e1-4c7e-8c5a-c2c20e051d98"), Type = TextBlockType.Text, Text = "You hear the sounds of reptiles as language. You can ask questions of, receive answers from, and use the Diplomacy skill with animals that are reptiles (the GM determines which animals count as reptiles)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("591d61ad-4d1f-4056-b50b-ca02b3084e7b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
