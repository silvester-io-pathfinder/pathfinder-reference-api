using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisruptKi : Template
    {
        public static readonly Guid ID = Guid.Parse("c59c3c8b-bfb0-4d92-99f2-e34835cd765a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disrupt Ki",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98ed8cd7-6114-46c3-a655-74aaefd8d502"), Type = TextBlockType.Text, Text = "Make an unarmed (action: Strike). If it deals damage to a living creature, you block that creature’s inner life force. The creature takes 2d6 persistent negative damage and is enfeebled 1 until the persistent damage ends. If you’re 18th level or higher, this deals 3d6 persistent negative damage instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91f4ad26-0e7b-4c14-b986-3b9be7c12f10"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
