using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelestialResistanceFire : Template
    {
        public static readonly Guid ID = Guid.Parse("6c9a29ec-3de0-424b-aee9-7067f888a4d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Resistance - Fire",
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
            yield return new TextBlock { Id = Guid.Parse("7fdcc4d0-dcee-48a7-8e52-bbeeaafda9ae"), Type = TextBlockType.Text, Text = "You gain resistance 5 to fire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ece2d932-6dd8-4d78-b9c0-a4aa4c674403"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
