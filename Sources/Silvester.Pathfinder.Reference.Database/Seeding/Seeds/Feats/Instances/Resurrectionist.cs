using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Resurrectionist : Template
    {
        public static readonly Guid ID = Guid.Parse("36b62029-207e-4ff8-a646-b5c4de531e1b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resurrectionist",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bffcd2d1-c1bb-4960-955e-4fcf033729f1"), Type = TextBlockType.Text, Text = "You can cause a creature you bring back from the brink of death to thrive and continue healing. When you restore Hit Points to a dying creature or bring a dead creature back to life and restore Hit Points to it, you grant that creature fast healing 5 for 1 minute. This fast healing ends if the creature is knocked unconscious." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63432385-38e5-42b7-ab2a-0b072b892a09"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
