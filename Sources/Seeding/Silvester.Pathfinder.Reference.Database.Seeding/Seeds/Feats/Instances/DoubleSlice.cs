using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DoubleSlice : Template
    {
        public static readonly Guid ID = Guid.Parse("1ba45ed1-cd63-444b-8739-5df1de8583cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Double Slice",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cff12066-c359-446a-90c1-bfde8f6e1dc6"), Type = TextBlockType.Text, Text = "You lash out at your foe with both weapons. Make two (Action: Strikes | Strike), one with each of your two melee weapons, each using your current multiple attack penalty. Both (Action: Strikes | Strike) must have the same target. If the second (Action: Strike) is made with a weapon that doesn’t have the (trait: agile) trait, it takes a -2 penalty." };
            yield return new TextBlock { Id = Guid.Parse("2d596907-f0ff-4d3a-a300-52a4b1ea62ea"), Type = TextBlockType.Text, Text = "If both attacks hit, combine their damage, and then add any other applicable effects from both weapons. You add any precision damage only once, to the attack of your choice. Combine the damage from both (Action: Strikes | Strike) and apply resistances and weaknesses only once. This counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b3eafeb-82c1-4ace-b1fc-fc2528cede09"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}