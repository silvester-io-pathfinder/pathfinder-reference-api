using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EverdistantDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("6bb02e87-44e1-48d6-99ab-c7b3770d6b7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Everdistant Defense",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your aura is targeted by a ranged attack or a creature moves through your aura.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a12da31a-20cd-4962-9795-56cd08bda54c"), Type = TextBlockType.Text, Text = "The spatial barrier of Syndara&#39;s Island has taught you that distance can foil enemies better than any armor. You warp space, causing each square within your aura that the attack or creature would move through to count as triple the distance. If this reaction is used on a ranged attack, the attack takes range increment penalties based on the adjusted range and fails if this would cause it to exceed its maximum range." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdf66855-2586-43ea-b990-fec241ae5a2c"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
