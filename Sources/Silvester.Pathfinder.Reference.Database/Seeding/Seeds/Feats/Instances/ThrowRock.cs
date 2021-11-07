using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThrowRock : Template
    {
        public static readonly Guid ID = Guid.Parse("b44afda2-2cf3-496c-9f4d-e2b8fe9de1bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Throw Rock",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8cbc9164-213e-4da8-ab63-d8483d393de4"), Type = TextBlockType.Text, Text = "The arboreal sapling (action: Interacts | Interact) to pick up a rock within reach or retrieve a stowed rock, then throws it with a ranged rock (action: Strike) that deals a base of 1d6 bludgeoning damage with a range increment of 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6886a95-1aad-47b6-99be-2049008c0ea3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
