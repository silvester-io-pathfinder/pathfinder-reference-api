using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShapechangersIntuition : Template
    {
        public static readonly Guid ID = Guid.Parse("38278073-edb6-4d83-968c-a541f2c3b80c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shapechanger's Intuition",
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
            yield return new TextBlock { Id = Guid.Parse("6a363302-c52b-439b-a331-423e09b518dd"), Type = TextBlockType.Text, Text = "A lifetime of experience helps you see through disguises. When you come within 10 feet of a creature that is transformed into another form or is (action: Impersonating | Impersonate) a specific creature, the GM rolls a secret Perception check for you to realize that the creature is transformed, even if you didn’t spend an action to (action: Seek) against that creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0b77b68-4e45-4145-885f-bb04c4362c80"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
