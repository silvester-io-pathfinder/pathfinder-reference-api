using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TandemMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("559af93f-65ce-45a6-b275-1fea45e59777");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tandem Movement",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("443b38dd-75fc-48d3-806f-97fbe69eecc7"), Type = TextBlockType.Text, Text = "You and your eidolon move together. You each use a single action to (action: Stride). Either of you that has the corresponding movement type can (action: Burrow), (action: Climb), (action: Fly), or (action: Swim) instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("799fcd56-4ddf-4bcc-ab36-9a9faed9c286"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
