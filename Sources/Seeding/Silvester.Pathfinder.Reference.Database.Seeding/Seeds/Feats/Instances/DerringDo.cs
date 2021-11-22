using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DerringDo : Template
    {
        public static readonly Guid ID = Guid.Parse("a35d0aa3-2e33-4874-9733-265a833f8475");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Derring-Do",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c58f5f8-425e-4166-924c-d4c633b1b814"), Type = TextBlockType.Text, Text = "When you compound panache with even more derring-do, it somehow tends to work out. When you already have panache, you can roll twice and use the higher result on checks to which the circumstance bonus for having panache applies ((action: Tumble Through) and any skill actions listed in your swashbuckler's style)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69c7e578-c750-41c0-84fc-b1c9d26c2fb5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
