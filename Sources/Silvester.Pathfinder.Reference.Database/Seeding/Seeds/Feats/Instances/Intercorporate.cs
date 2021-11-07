using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Intercorporate : Template
    {
        public static readonly Guid ID = Guid.Parse("49380b98-f4ee-4b80-be69-5c5b61aefc3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intercorporate",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e960d9f-a9b4-4acc-bbc8-e44c59d50490"), Type = TextBlockType.Text, Text = "Your ordered physiology rejects unwelcome elements. Choose one." };
            yield return new TextBlock { Id = Guid.Parse("37ffc6b3-b991-479f-9544-e256df5f7b6c"), Type = TextBlockType.Enumeration, Text = " Disease or Poison: Attempt a saving throw against the affliction at its current stage. On a failure, the affliction’s stage doesn’t increase, but you suffer the effects of the stage you were already on. On a critical failure, the stage only increases by 1." };
            yield return new TextBlock { Id = Guid.Parse("963e14a8-6713-4e5d-9fbd-0a113c1268b3"), Type = TextBlockType.Enumeration, Text = " Persistent Damage: Attempt a DC 10 flat check to recover from the persistent damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("411ac54c-e564-4d23-9986-8cc5e1bc7fca"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
