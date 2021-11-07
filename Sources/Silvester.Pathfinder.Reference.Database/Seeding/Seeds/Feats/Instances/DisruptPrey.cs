using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DisruptPrey : Template
    {
        public static readonly Guid ID = Guid.Parse("6aee18a4-b742-4bd0-a645-8eefaf509cc6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disrupt Prey",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your hunted prey is within your reach, and it uses a manipulate action, uses a move action, or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d2ae70d-087c-4605-b8f6-082ef11eccc2"), Type = TextBlockType.Text, Text = "Make a melee (action: Strike) against your prey. If the attack is a critical hit, you disrupt the triggering action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c1a04d0-5a32-4942-ab5b-5eddbae3289f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
