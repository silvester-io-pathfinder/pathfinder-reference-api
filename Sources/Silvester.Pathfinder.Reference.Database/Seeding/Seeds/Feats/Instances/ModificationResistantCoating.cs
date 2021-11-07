using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationResistantCoating : Template
    {
        public static readonly Guid ID = Guid.Parse("53ded05d-8851-44ca-a8ba-355d66253781");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Resistant Coating",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f53cb531-64b4-42c1-9902-bac171df74ca"), Type = TextBlockType.Text, Text = "Your innovation is hard to damage by any means. It gains resistance 5 to all damage (except adamantine)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85d8203d-da67-424d-b245-5b523457d5e0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
