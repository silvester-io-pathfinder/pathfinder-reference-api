using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImposeOrder : Template
    {
        public static readonly Guid ID = Guid.Parse("c7604329-9ddf-46e1-bb70-60d1335357c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impose Order",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would critically fail a skill check or suffer an effect with the misfortune trait.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("702b055d-8ce7-4ea9-8288-0f223aae3024"), Type = TextBlockType.Text, Text = "You shift the underlying fabric of reality to impose a baseline of order. If the trigger was a skill check, you instead receive a result of 10 + your proficiency bonus (don’t apply any other bonuses, penalties, or modifiers). If the trigger was an effect with the (trait: misfortune) trait, the (trait: misfortune) and (trait: fortune) effects cancel each other out as normal, negating the triggering (trait: misfortune) effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7365ac45-b7dd-4e6e-a19d-d033ed64b39b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
