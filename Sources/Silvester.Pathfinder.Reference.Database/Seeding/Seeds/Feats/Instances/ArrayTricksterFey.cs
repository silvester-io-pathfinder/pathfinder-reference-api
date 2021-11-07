using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArrayTricksterFey : Template
    {
        public static readonly Guid ID = Guid.Parse("2efe5f39-4315-4eb5-baeb-258027293bcc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Array - Trickster Fey",
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
            yield return new TextBlock { Id = Guid.Parse("bc3a03c4-82bb-4c12-8679-d38a1cc1695a"), Type = TextBlockType.Text, Text = "~ Trickster Fey: __Str__ 12, __Dex__ 18, __Con__ 12, __Int__ 12, __Wis__ 8, __Cha__ 16; +1 AC (+4 Dex cap)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca6bce14-a67b-40db-9c80-24397c2a35cf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
