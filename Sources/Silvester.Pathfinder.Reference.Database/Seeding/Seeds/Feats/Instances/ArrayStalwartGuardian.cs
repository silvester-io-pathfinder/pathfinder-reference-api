using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrayStalwartGuardian : Template
    {
        public static readonly Guid ID = Guid.Parse("d5ae6044-623e-4b98-9446-0f9c7be6ea95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Array - Stalwart Guardian",
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
            yield return new TextBlock { Id = Guid.Parse("89d1cb02-e191-44fb-ad16-1e5d685f78ad"), Type = TextBlockType.Text, Text = "~ Stalwart Guardian: __Str__ 18, __Dex__ 14, __Con__ 16, __Int__ 10, __Wis__ 10, __Cha__ 10; +2 AC (+3 Dex cap)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f82a7ef-f05e-427b-8ff9-d3927c9acbb2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
