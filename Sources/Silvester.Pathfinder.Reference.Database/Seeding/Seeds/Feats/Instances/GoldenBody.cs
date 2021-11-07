using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoldenBody : Template
    {
        public static readonly Guid ID = Guid.Parse("d39339e9-5571-4f8d-8f39-b055aa241a9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Golden Body",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61f43106-4c9a-4820-b379-cc820249b71a"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor’s Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("5724dced-863d-46eb-9be0-9c0d4e00db7b"), Type = TextBlockType.Text, Text = "You perfect your body, refining the flex of every muscle and the bend of every joint to maximum efficiency. Your unarmed (action: Strikes | Strike) gain the (trait: deadly d12) trait, and you have fast healing 20, causing you to regain 20 HP at the start of each of your turns provided you have at least 1 HP." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0afa2e1-e70a-4b98-8238-6f245572dd70"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
