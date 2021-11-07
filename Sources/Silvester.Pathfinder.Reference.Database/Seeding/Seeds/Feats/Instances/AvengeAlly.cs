using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AvengeAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("9ce06e7e-5aba-4337-83a5-46eeb3a542c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Avenge Ally",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6bb4bdf-3093-488e-87e6-eb132f27f8f3"), Type = TextBlockType.Text, Text = "Though you know that you will eventually outlive your companions, seeing them at death&#39;s door brings clarity to your attacks. Make a (action: Strike). Roll twice on the attack roll and use the higher result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29abd15b-429b-41ad-8b27-8176d9c2a981"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
