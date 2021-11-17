using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class FishseekerShoony : Template
    {
        public static readonly Guid ID = Guid.Parse("6c2b8c5f-03d2-4f8e-9440-faf26725e392");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Fishseeker Shoony"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c25de140-c6f1-4023-baef-2e8672573bb3"), Type = TextBlockType.Text, Text = "You come from a long line of fisherfolk and have inherited the quick reflexes necessary to nab and reel in big game. If you roll a success on an attempt to Grab an Edge, you get a critical success instead; if you roll a critical failure, you get a failure instead. A creature that rolls a failure on a check to Disarm you gets a critical failure instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificActionCheck(Guid.Parse("837f3118-5bfc-43e9-9852-bbfb49cae590"), Actions.Instances.GrabEdge.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificActionCheck(Guid.Parse("b829688e-61fc-4f6e-a489-1546f071d041"), Actions.Instances.GrabEdge.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            builder.Manual(Guid.Parse("1b902dcc-43f2-436f-874d-a1d9e8a0c589"), "A creature that rolls a failure on a check to Disarm you gets a critical failure instead.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd93181f-5a69-4f42-a4b0-b32e84047949"),
                SourceId = Sources.Instances.Pathfinder153.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Shoony.ID;
        }
    }
}
