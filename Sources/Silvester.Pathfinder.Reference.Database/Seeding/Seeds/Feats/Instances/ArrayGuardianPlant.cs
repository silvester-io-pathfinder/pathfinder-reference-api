using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrayGuardianPlant : Template
    {
        public static readonly Guid ID = Guid.Parse("7df59c9e-0cd9-4843-9c41-a8b7e057a9eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Array - Guardian Plant",
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
            yield return new TextBlock { Id = Guid.Parse("9f99c4c2-16b4-47dd-b990-d9c7c4cce6dc"), Type = TextBlockType.Text, Text = "~ Guardian Plant: __Str__ 18, __Dex__ 14, __Con__ 16, __Int__ 8, __Wis__ 12, __Cha__ 10; +2 AC (+3 Dex cap)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acdeae32-1de7-40b6-9a35-a6eaec19f48a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
