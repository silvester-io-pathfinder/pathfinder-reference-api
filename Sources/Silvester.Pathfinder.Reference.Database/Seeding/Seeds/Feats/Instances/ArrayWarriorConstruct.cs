using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrayWarriorConstruct : Template
    {
        public static readonly Guid ID = Guid.Parse("84b6b9b6-827a-4a6f-bf9e-c15e0177b12e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Array - Warrior Construct",
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
            yield return new TextBlock { Id = Guid.Parse("49119dac-dae1-4647-a906-46a1bf1073f8"), Type = TextBlockType.Text, Text = "~ Warrior Construct: __Str__ 18, __Dex__ 14, __Con__ 16, __Int__ 12, __Wis__ 10, __Cha__ 8; +2 AC (+3 Dex cap)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d950360a-b7e9-4fec-aa1e-c34bc213ee29"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
