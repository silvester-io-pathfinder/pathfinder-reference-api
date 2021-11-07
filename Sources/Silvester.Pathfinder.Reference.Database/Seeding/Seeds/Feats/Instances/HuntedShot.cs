using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntedShot : Template
    {
        public static readonly Guid ID = Guid.Parse("ae5092cd-2917-4dc6-aeaa-48f8de81d653");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunted Shot",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c16da28-f887-44d3-a865-4bc5c96bdf50"), Type = TextBlockType.Text, Text = "You take two quick shots against the one you hunt. Make two (action: Strikes | Strike) against your prey with the required weapon. If both hit the same creature, combine their damage for the purpose of resistances and weaknesses. Apply your multiple attack penalty to each (action: Strike) normally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40a7b201-c0d7-4f27-82b1-cdb83434bf82"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
