using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AttackOfOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("f8909057-eb5d-4103-9c45-e6edfb8e960a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Attack of Opportunity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach uses a manipulate action or a move action, makes a ranged attack, or leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1f5613d-da71-4e17-a7da-3c7441a799bf"), Type = TextBlockType.Text, Text = "You lash out at a vulnerable foe. Make a melee (action: Strike) against the triggering creature. If your attack is a critical hit and the trigger was a (trait: manipulate) action, you disrupt that action. This (action: Strike) doesn’t count toward your multiple attack penalty, and your multiple attack penalty doesn’t apply to this (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("482b543b-5085-4028-947c-725d0590415f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
