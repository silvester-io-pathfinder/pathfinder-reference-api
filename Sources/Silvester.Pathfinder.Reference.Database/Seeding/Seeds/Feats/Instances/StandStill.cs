using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StandStill : Template
    {
        public static readonly Guid ID = Guid.Parse("d56615e8-3e1d-4740-8927-1ce12c583888");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stand Still",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach uses a move action or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8257dd8-0841-43fa-b1d6-f36628d76343"), Type = TextBlockType.Text, Text = "You strike out when your foe tries to flee. Make a melee (action: Strike) against the triggering creature. If the attack is a critical hit and the trigger was a (trait: move) action, you disrupt that action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8b22d30-e76c-45ef-8984-432543a7892f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
