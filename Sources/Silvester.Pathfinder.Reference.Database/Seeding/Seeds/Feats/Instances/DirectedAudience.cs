using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DirectedAudience : Template
    {
        public static readonly Guid ID = Guid.Parse("f702f5da-0359-4bf0-a91d-c69c91052641");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Directed Audience",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("517b8133-d21b-48fd-a2d0-9870a49019dc"), Type = TextBlockType.Text, Text = "You can shape the area of your composition spells. Whenever you cast a composition spell whose area is an emanation, you can change the spell’s area to a cone 10 feet larger, to a maximum of twice the original area. For example, you could modify a composition spell that affects a 30-foot emanation to affect a 40-foot cone, but a 5-foot emanation could only become a 10-foot cone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("908ecd5d-b3e6-42d7-b4d6-727153e13ddc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
