using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmokeCurtain : Template
    {
        public static readonly Guid ID = Guid.Parse("d74985b1-a11a-4550-be99-0327f0272f90");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smoke Curtain",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff7fb80e-d096-48be-b170-e6e7372615f8"), Type = TextBlockType.Text, Text = "You load an extra dose of powder into your shot, causing it to belch a cloud of smoke. You make a (action: Strike) with your firearm and create a cloud of smoke in a 20-foot emanation centered on your location. Creatures are concealed while within the smoke, and creatures outside the area are concealed to creatures within the smoke. The smoke dissipates at the start of your next turn. If your (action: Strike) is a critical failure, your firearm misfires." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77ad81fb-6541-4464-b9fe-1ccfcd516761"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
