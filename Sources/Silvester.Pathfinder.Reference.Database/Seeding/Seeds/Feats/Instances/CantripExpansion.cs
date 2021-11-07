using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CantripExpansion : Template
    {
        public static readonly Guid ID = Guid.Parse("01d31c9a-3253-4133-b5e1-ab4bec8c3f41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cantrip Expansion",
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
            yield return new TextBlock { Id = Guid.Parse("1440e76a-7a76-4505-b306-713d7c09d2c9"), Type = TextBlockType.Text, Text = "With a bit of introspection, you realize that your mind can accomplish so much more. Add two additional occult cantrips to your repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92d11050-74c0-4b94-ae8f-9dcf913b7ef9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
