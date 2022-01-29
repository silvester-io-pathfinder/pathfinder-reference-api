using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Twitchy : Template
    {
        public static readonly Guid ID = Guid.Parse("026afd30-1d04-4eb3-a7e8-84ec2ed70e83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twitchy",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d6d5c10-4aab-4cf4-95bf-0459ad763e64"), Type = TextBlockType.Text, Text = $"You are naturally suspicious and wary of danger, especially when you suspect someone might be leading you into an ambush. You gain a +1 circumstance bonus to AC and saves against hazards, and to all of your initiative rolls. If at least one of your opponents is using Deception or Diplomacy to determine their initiative, your bonus to initiative from this feat increases to +4." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c2fbd2bf-95c5-4b6c-9192-5eb93e5fc73f"), Traits.Instances.Goblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53d51c1b-e73c-4602-ba5c-61520c22a668"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
