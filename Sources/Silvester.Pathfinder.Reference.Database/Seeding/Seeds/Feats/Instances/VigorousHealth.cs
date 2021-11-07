using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VigorousHealth : Template
    {
        public static readonly Guid ID = Guid.Parse("01abf42d-220c-4427-8673-c8f486c50159");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vigorous Health",
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
            yield return new TextBlock { Id = Guid.Parse("0fc21606-2095-4934-86ab-67bb93201499"), Type = TextBlockType.Text, Text = "Your physique is robust and can withstand blood loss startlingly well. Whenever you would gain the drained condition, you can attempt a DC 17 flat check. On a success, you don’t gain the drained condition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0252bafb-d8f6-43e9-971d-703506e601f4"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
