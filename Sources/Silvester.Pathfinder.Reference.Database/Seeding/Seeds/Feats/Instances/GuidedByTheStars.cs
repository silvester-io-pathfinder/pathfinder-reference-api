using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GuidedByTheStars : Template
    {
        public static readonly Guid ID = Guid.Parse("aed9ed62-90c3-4e08-9219-f1a5eedfdf64");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guided by the Stars",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to attempt a skill check or saving throw.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff1723c7-c39e-45a3-b0b2-19f5c70efd20"), Type = TextBlockType.Text, Text = "The stars grant you insights that guide your actions. You roll twice and take the better result. If it’s night and you can see the stars, you gain a +1 circumstance bonus to the triggering roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21041c33-b564-41ab-812a-eb33e7fdb7d4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
