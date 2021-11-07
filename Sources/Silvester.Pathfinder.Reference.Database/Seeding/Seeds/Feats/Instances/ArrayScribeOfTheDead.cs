using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrayScribeOfTheDead : Template
    {
        public static readonly Guid ID = Guid.Parse("422dd762-f912-463b-97d9-387367f95362");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Array - Scribe of the Dead",
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
            yield return new TextBlock { Id = Guid.Parse("c8e27b6a-5a7d-49ac-a38f-1d7c28b475ed"), Type = TextBlockType.Text, Text = "~ Scribe of the Dead: __Str__ 12, __Dex__ 18, __Con__ 12, __Int__ 14, __Wis__ 12, __Cha__ 10; +1 AC (+4 Dex cap)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cc86443-d361-4d48-8dbc-e6a494d3643e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
