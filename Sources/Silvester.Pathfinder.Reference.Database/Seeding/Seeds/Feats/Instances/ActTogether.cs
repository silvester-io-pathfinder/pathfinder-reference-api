using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ActTogether : Template
    {
        public static readonly Guid ID = Guid.Parse("3cb77680-0681-47ca-885b-9eee5302c020");

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
            yield return new TextBlock { Id = Guid.Parse("d4eafeb3-d799-4eb0-96fd-8ad1a99d1a55"), Type = TextBlockType.Text, Text = "You and your eidolon act as one. Either you or your eidolon takes an action or activity using the same number of actions as Act Together, and the other takes a single action." };
            yield return new TextBlock { Id = Guid.Parse("bb72437a-11d8-41b8-85dc-fb2ddb8959ed"), Type = TextBlockType.Text, Text = "For example, if you spent 2 actions to Act Together, you could cast (spell: burning hands) (2 actions) and your eidolon could (action: Strike) (1 action), or your eidolon could use its (action: Breath Weapon) (2 actions) and you could (action: Stride) (1 action)." };
            yield return new TextBlock { Id = Guid.Parse("7dfb9a4d-268a-4e5d-8c3a-db7bf2fa18f3"), Type = TextBlockType.Text, Text = "This lets you each use separate exploration activities like (activity: Avoid Notice) as you travel (CRB pg. 496)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6496f8e3-cbfe-4a89-b904-1711af71a9a1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
