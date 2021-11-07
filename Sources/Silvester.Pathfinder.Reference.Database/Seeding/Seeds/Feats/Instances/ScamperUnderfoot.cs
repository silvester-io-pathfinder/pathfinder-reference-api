using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScamperUnderfoot : Template
    {
        public static readonly Guid ID = Guid.Parse("80b475d7-40a4-4183-87d8-a543120d76f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scamper Underfoot",
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
            yield return new TextBlock { Id = Guid.Parse("766db68b-3ccd-4f54-9101-00cc4d366981"), Type = TextBlockType.Text, Text = "You are used to ducking under foes and can scurry around the battlefield with ease. You gain a +1 circumstance bonus to Acrobatics checks to (action: Tumble Through) the spaces of Medium or larger enemies, and the presence of an enemy doesn’t make the squares difficult terrain." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c6dd109-bf12-4cf0-9c81-540ea50a6ac6"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
