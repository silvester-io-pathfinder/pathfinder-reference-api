using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EvadeDoom : Template
    {
        public static readonly Guid ID = Guid.Parse("3321bd91-8ce3-45ec-8586-a69a9615c58a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Evade Doom",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a759a41f-d356-4134-afcc-1d1a43510139"), Type = TextBlockType.Text, Text = "You can elude supernatural disaster. When you would gain the doomed condition, you can attempt a DC 17 flat check. On a success, you don't gain the doomed condition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56b8c98f-dbaf-4acc-9c0e-79025dbae812"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
