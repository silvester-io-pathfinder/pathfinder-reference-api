using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurfaceSkimmer : Template
    {
        public static readonly Guid ID = Guid.Parse("73516ec2-f08e-4285-b62a-693cd009f235");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surface Skimmer",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2c08281-bf46-46c0-b391-f7291740176d"), Type = TextBlockType.Text, Text = "By sinking gently beneath the waves, you obscure your presence and utilize the water as a barrier between you and land combatants. While you are submerged just below the water's surface, you have cover from attacks made by creatures out of the water." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38602c3c-3425-4f8c-b969-1c793675c537"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
