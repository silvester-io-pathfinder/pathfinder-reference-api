using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DemolitionistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0d5b3f55-3e50-42ec-a537-48fcfba8b4ec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demolitionist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("607a5608-65bd-47d2-8412-7382fbcd71f8"), Type = TextBlockType.Text, Text = "You know how to set explosives to cause the maximum possible damage to buildings and other structures. You become trained in Engineering Lore or become an expert in it if you were already trained. You gain the (feat: Set Explosives) action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9ad343c-2d45-495c-a6ea-c535d60142da"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
