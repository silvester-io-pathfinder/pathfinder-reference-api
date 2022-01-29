using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenPaces : Template
    {
        public static readonly Guid ID = Guid.Parse("615845de-d6cb-463d-b70d-ec056de885f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ten Paces",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("61032a28-a129-4a8c-a645-a3611d57e70c"), Type = TextBlockType.Text, Text = $"You react to trouble with lightning speed, positioning yourself just right. You gain a +2 circumstance bonus to your initiative roll, and you can {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw a one-handed firearm or one-handed crossbow. As your first action on your first turn, you can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} up to 10 feet as a free action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac2a0a2d-1a2d-467b-98ae-293f20e491c7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
