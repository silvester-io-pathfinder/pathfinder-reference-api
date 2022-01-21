using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BucklerExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("54e1145b-c101-47cb-a391-d76e2ef2f7e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Buckler Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("2cb29cd0-f289-4955-bf6d-b0b4a7584cc8"), Type = TextBlockType.Text, Text = $"You've learned a flexible way to position your buckler to provide more protection. When you {ToMarkdownLink<Models.Entities.Action>("Raise a Shield", Actions.Instances.RaiseAShield.ID)} to gain a circumstance bonus to AC from a {ToMarkdownLink<Models.Items.Instances.Shield>("buckler", Items.Shields.Instances.Buckler.ID)}, increase the bonus from +1 to +2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4c7c370-438e-4310-a8c9-9ec1c2e249c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
