using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TongueOfSunAndMoon : Template
    {
        public static readonly Guid ID = Guid.Parse("0e3434ed-8d87-4a0b-a0ca-c2216c27486b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tongue of Sun and Moon",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb90c432-aa39-4004-aeff-31a9ee177dcf"), Type = TextBlockType.Text, Text = "You have transcended the barriers between words and meaning. You can speak and understand all spoken languages." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd8b4db4-5e60-4b19-8fb5-362584e561a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
