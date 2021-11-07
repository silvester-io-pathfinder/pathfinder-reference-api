using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EverdistantDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("63e05923-9a50-4584-8b05-1c032244e270");

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
            yield return new TextBlock { Id = Guid.Parse("64cb4bb5-1ec8-48cb-87e8-45d7a3f1ce33"), Type = TextBlockType.Text, Text = "The spatial barrier of Syndara&#39;s Island has taught you that distance can foil enemies better than any armor. You warp space, causing each square within your aura that the attack or creature would move through to count as triple the distance. If this reaction is used on a ranged attack, the attack takes range increment penalties based on the adjusted range and fails if this would cause it to exceed its maximum range." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e5e1321-9b60-4c82-a7fb-8d261c1ac457"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
