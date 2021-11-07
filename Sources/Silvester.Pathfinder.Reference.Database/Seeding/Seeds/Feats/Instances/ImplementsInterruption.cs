using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplementsInterruption : Template
    {
        public static readonly Guid ID = Guid.Parse("4e637e5e-02da-4bf2-9f70-fb5cbe9a58dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implement's Interruption",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "The subject of your Esoteric Antithesis uses a concentrate, manipulate, or move action, or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84207205-ddb5-4005-a282-5a900e901cee"), Type = TextBlockType.Text, Text = "Charged with power inimical to your foe, your weapon lashes out to attack it. Make a (action: Strike) against the triggering creature with your weapon implement. If your attack is a critical hit, you disrupt that action. This (action: Strike) doesn’t count toward your multiple attack penalty, and your multiple attack penalty doesn’t apply to this (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1f7bcdb-c837-4ad2-870a-5b8e60750db6"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
