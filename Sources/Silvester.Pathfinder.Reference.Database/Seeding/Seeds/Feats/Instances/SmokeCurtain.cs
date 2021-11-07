using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmokeCurtain : Template
    {
        public static readonly Guid ID = Guid.Parse("93e04b41-ce64-4f77-a327-8bfe81bfaaf7");

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
            yield return new TextBlock { Id = Guid.Parse("4ffe7cb6-3830-4718-b047-643c1cb3cd41"), Type = TextBlockType.Text, Text = "You load an extra dose of powder into your shot, causing it to belch a cloud of smoke. You make a (action: Strike) with your firearm and create a cloud of smoke in a 20-foot emanation centered on your location. Creatures are concealed while within the smoke, and creatures outside the area are concealed to creatures within the smoke. The smoke dissipates at the start of your next turn. If your (action: Strike) is a critical failure, your firearm (trait: misfires|misfire)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7479bf0-7e11-4970-9a2a-b565f6c4b5d9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
