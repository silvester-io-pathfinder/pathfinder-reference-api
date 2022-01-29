using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwistTheKnife : Template
    {
        public static readonly Guid ID = Guid.Parse("2a8b587e-1b17-48b1-ad76-55fdc643c18a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twist the Knife",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15922fc5-19df-4534-868d-9b6dbdd33770"), Type = TextBlockType.Text, Text = $"After stabbing your opponent in a weak spot, you tear the wound open. You deal persistent bleed damage to the target equal to your number of sneak attack damage dice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d116f2ca-f330-486a-bf1c-3aea4aacea2c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
