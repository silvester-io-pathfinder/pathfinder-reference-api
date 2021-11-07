using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Explode : Template
    {
        public static readonly Guid ID = Guid.Parse("8b85469d-3cee-473c-9d6f-f5079f0b0968");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explode",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a745e4d3-0b8f-491d-a801-23647fc6a6ab"), Type = TextBlockType.Text, Text = "You intentionally take your innovation beyond normal safety limits, making it explode and damage nearby creatures without damaging the innovation... hopefully. The explosion deals 2d6 fire damage with a basic Reflex save to all creatures in a 5-foot emanation around you (if you’re wearing or holding the innovation) or around your innovation (if your innovation is a minion)." };
            yield return new TextBlock { Id = Guid.Parse("08f7b228-4886-4ef9-a79d-3edad708cff0"), Type = TextBlockType.Text, Text = "At 3rd level, and every level thereafter, increase your explosion’s damage by 1d6." };
            yield return new TextBlock { Id = Guid.Parse("8f379edb-14a9-46dc-b007-3b1ad9dc102b"), Type = TextBlockType.Text, Text = "If you have the breakthrough innovation class feature, you can choose either a 5-foot or 10-foot emanation for the area when you use Explode; if you have the revolutionary innovation class feature, you can choose a 5-foot, 10-foot, or 15-foot emanation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a77ed1cf-1def-4e99-8788-126a1af3f4a2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
