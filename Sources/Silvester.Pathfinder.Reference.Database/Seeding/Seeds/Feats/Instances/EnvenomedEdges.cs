using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvenomedEdges : Template
    {
        public static readonly Guid ID = Guid.Parse("704e7b32-1624-4ee7-bb77-c5d384401cef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Envenomed Edges",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a42cbad0-3d5a-48b6-bd33-2c7be3b2d6b8"), Type = TextBlockType.Text, Text = "With a combination of your poison glands and herbal concoctions, you can consistently deliver venomous attacks when you hit an enemy’s weak points. When you critically hit using a (action: Strike) with a weapon or unarmed attack and deal slashing or piercing damage with that (action: Strike), you deal an additional 1d4 persistent poison damage to your target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a44e6541-f38b-4d06-b4ac-86befd5955cc"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
