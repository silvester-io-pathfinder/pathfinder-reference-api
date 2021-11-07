using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelRau : Template
    {
        public static readonly Guid ID = Guid.Parse("222ce395-fa01-48bc-b3b5-a682fe5c7c17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cel Rau",
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
            yield return new TextBlock { Id = Guid.Parse("4e28b6e3-cac0-4ea7-86d0-8e33ab49584e"), Type = TextBlockType.Text, Text = "You are a cel rau, child of a strigoi, one of the first vampires to walk Golarion. Your heritage ties you to the Shadow Plane and grants you strange resilience to light and darkness alike. You gain a +1 circumstance bonus to saving throws against effects with the (trait: darkness), (trait: light), or (trait: shadow) traits, and whenever you become dazzled or blinded for at least 2 rounds, you can reduce the duration by 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13daac36-1a32-47a3-b645-7d2bf9cb6d0f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
