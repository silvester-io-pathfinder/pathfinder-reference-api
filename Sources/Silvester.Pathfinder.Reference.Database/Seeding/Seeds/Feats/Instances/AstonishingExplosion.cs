using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AstonishingExplosion : Template
    {
        public static readonly Guid ID = Guid.Parse("ce40ee23-efa2-4aff-9f8e-7644831b0f01");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Astonishing Explosion",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Quick Alchemy to craft an alchemical bomb that deals splash damage and is at least 2 levels lower than your advanced alchemy level.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("183d003f-ef74-4c18-8a66-85366c3c86bc"), Type = TextBlockType.Text, Text = "Your bomb incorporates an explosive spark of wonder that leaves witnesses dumbfounded. Any target hit by your (action: Strike) with the bomb is fascinated by you for 1 round. On a critical success, the target is also stunned 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("278a176d-1ee1-41b9-9c7f-1b1d3ca16d54"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
