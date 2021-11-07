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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You come from a long line of fisherfolk and have inherited the quick reflexes necessary to nab and reel in big game. If you roll a success on an attempt to Grab an Edge, you get a critical success instead; if you roll a critical failure, you get a failure instead. A creature that rolls a failure on a check to Disarm you gets a critical failure instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificActionCheck(Guid.Parse(""), Actions.Instances.GrabEdge.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
            builder.ImproveSpecificActionCheck(Guid.Parse(""), Actions.Instances.GrabEdge.ID, RollResult.CriticalFailure, becomes: RollResult.Failure);
            builder.Manual(Guid.Parse(""), "A creature that rolls a failure on a check to Disarm you gets a critical failure instead.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
