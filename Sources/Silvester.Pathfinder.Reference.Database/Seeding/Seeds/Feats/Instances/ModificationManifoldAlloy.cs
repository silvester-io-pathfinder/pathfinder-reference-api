using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationManifoldAlloy : Template
    {
        public static readonly Guid ID = Guid.Parse("f2192652-9fbe-4520-8187-f682d6f0ea94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Manifold Alloy",
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
            yield return new TextBlock { Id = Guid.Parse("f19cb5b5-965c-492a-8aba-0f0eeefa6055"), Type = TextBlockType.Text, Text = "You’ve devised several alloys that contain useful properties of various metals, and you replace a number of parts of your weapon or its ammunition with pieces from these alloys. Your weapon innovation is cold iron and silver. This means you deal more damage to a variety of supernatural creatures, such as demons, devils, and fey." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18ce675c-3068-4187-b197-feca9a6615c3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
