using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FountainOfSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("bfab3649-abf5-4b32-afaf-be27181b9e43");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fountain of Secrets",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06b02060-6fb4-4a0c-9b56-92b1888480ec"), Type = TextBlockType.Text, Text = "You constantly remember details about the world. You attempt a check to (action: Recall Knowledge). If you succeed, you gain additional information or context. If you critically succeed, at the GM’s discretion you might gain even more additional information or context than normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c847d96-3ebd-4ddc-8453-7d19b05326f5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
