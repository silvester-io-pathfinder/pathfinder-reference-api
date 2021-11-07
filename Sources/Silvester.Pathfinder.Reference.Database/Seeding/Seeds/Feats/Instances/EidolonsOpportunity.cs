using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EidolonsOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("f6705de7-34bd-4aba-830b-e9d769341f83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidolon's Opportunity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your eidolon's reach uses a manipulate action or a move action, makes a ranged attack, or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e4695c40-6b8a-4f47-9e2b-520addd0738e"), Type = TextBlockType.Text, Text = "Your eidolon makes a melee (action: Strike) against the triggering creature. If the attack is a critical hit and the trigger was a (trait: manipulate) action, your eidolon disrupts that action. This (action: Strike) doesn’t count toward your multiple attack penalty, and your multiple attack penalty doesn’t apply to this (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("774e1cde-d922-4b15-89b2-f01b18293c1d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
