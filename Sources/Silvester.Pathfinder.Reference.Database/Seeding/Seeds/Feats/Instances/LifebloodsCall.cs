using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LifebloodsCall : Template
    {
        public static readonly Guid ID = Guid.Parse("b80e49d2-5bb5-4062-b527-11cb85d22083");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lifeblood's Call",
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
            yield return new TextBlock { Id = Guid.Parse("8404387d-4f36-40e8-8b5c-01879871a6a1"), Type = TextBlockType.Text, Text = "The impulse to survive and continue fighting resonates deep within you. You gain a circumstance bonus to damage rolls on your melee (action: Strikes | Strike) equal to twice the sum of your wounded and doomed conditions (to a maximum of a +8 circumstance bonus to damage) whenever you have one or both conditions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("384a2ba5-d637-45a3-824e-68846c969c57"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
