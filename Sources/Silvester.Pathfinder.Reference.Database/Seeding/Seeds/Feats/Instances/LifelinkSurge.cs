using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LifelinkSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("100ec804-c5ae-4e52-b223-db2052ab6ad5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lifelink Surge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ddf112f-44aa-44e0-887f-327279d5a36f"), Type = TextBlockType.Text, Text = "You learn the (spell: lifelink surge) link spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6172f03-a9ee-47c0-b46f-c9ab3ed04e1a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
