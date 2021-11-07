using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TerrainAdvantage : Template
    {
        public static readonly Guid ID = Guid.Parse("9ae7a82d-4794-418b-b33e-8c6a02ecec7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terrain Advantage",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4a0d82ad-ae56-40db-8570-b4d565e2bd0e"), Type = TextBlockType.Text, Text = "You can take advantage of the terrain to bypass foes’ defenses. Non-lizardfolk creatures in difficult terrain are flat-footed to you. If you have a swim Speed, non-lizardfolk creatures that are in water and lack a swim Speed are also flat-footed to you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d302f86b-bacb-4433-8dbe-a7b935bd9298"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
