using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChangeShapeAnadi : Template
    {
        public static readonly Guid ID = Guid.Parse("cd00d228-b8c8-4bdb-a698-4dff84679d32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Change Shape - Anadi",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d57252bd-3b04-4b91-9a34-de998fd074c9"), Type = TextBlockType.Text, Text = "You change into your human or spider shape. Each shape has a specific, persistent appearance. In your human shape, you can't use unarmed attacks granted by your ancestry. In your spider shape, you aren't flat-footed when climbing, but you can't use weapons, shields, or other held items of any sort nor can you take any action that has the (trait: manipulate) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11c01cbc-4cda-417d-90b8-d3269f9b8527"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
