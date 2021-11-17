using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ActTogether : Template
    {
        public static readonly Guid ID = Guid.Parse("f80209d7-5089-4fa8-b9f3-cd7070f3e014");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Act Together",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can spend ONE-ACTION to THREE-ACTIONS using Act Together.",
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1ce9209-c896-4b85-bdc0-e8a624b07ad7"), Type = TextBlockType.Text, Text = "You and your eidolon act as one. Either you or your eidolon takes an action or activity using the same number of actions as Act Together, and the other takes a single action." };
            yield return new TextBlock { Id = Guid.Parse("97cc8b62-709c-43fd-ba1a-ec1f3be7aa7b"), Type = TextBlockType.Text, Text = "For example, if you spent 2 actions to Act Together, you could cast (spell: burning hands) (2 actions) and your eidolon could (action: Strike) (1 action), or your eidolon could use its (action: Breath Weapon) (2 actions) and you could (action: Stride) (1 action)." };
            yield return new TextBlock { Id = Guid.Parse("e60be736-725f-4cb6-a599-3dc6a148ea27"), Type = TextBlockType.Text, Text = "This lets you each use separate exploration activities like (activity: Avoid Notice) as you travel (CRB pg. 496)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a69ca9f3-565c-4e0e-9c52-40834b720d60"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
