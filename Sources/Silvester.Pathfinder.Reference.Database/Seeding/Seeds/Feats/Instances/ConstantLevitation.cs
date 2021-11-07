using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConstantLevitation : Template
    {
        public static readonly Guid ID = Guid.Parse("128e0e4b-4afe-4b32-94ab-167eac7b9b38");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Constant Levitation",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26b6453a-ffc0-4738-8d80-8ee0c5229a78"), Type = TextBlockType.Text, Text = "Your power has unbound you from the earth below, letting you float harmlessly over traps and unstable terrain. You’re affected by a constant (spell: air walk), except the highest you can walk is 5 feet above the ground. While your psyche is unleashed, you’re also affected by a (spell: fly) spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdfd9303-d1a5-4fcf-8312-dc9f3daf8977"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
