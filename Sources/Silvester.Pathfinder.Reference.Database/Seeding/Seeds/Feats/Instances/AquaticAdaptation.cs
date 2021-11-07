using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AquaticAdaptation : Template
    {
        public static readonly Guid ID = Guid.Parse("8667b545-5e41-4ae5-a256-96218327df97");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aquatic Adaptation",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc8d0725-ad38-4cff-a0c4-8b21bc0c26e1"), Type = TextBlockType.Text, Text = "If you and up to four other creatures are in contact with a body of water deep enough for you to fully submerge, you can spend 10 minutes adapting the creatures to that specific body of water. This allows them to breathe normally while within that body of water and protects them from deep ocean pressure. These effects last until the creatures are no longer in contact with that body of water or until you use this ability again, whichever comes first for each creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("680fe4f1-1a18-461f-ab79-485cc280c579"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
