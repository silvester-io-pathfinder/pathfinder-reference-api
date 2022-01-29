using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MightyRage : Template
    {
        public static readonly Guid ID = Guid.Parse("55ed71e8-5a4d-42c3-89dc-ea943c2b2514");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mighty Rage",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use the Rage action on your turn.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8607e72-d302-4ca9-b51a-30bd015b00e2"), Type = TextBlockType.Text, Text = $"Use an action that has the {ToMarkdownLink<Models.Entities.Trait>("rage", Traits.Instances.Rage.ID)} trait. Alternatively, you can increase the actions of the triggering {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} to 2 to instead use a 2-action activity with the {ToMarkdownLink<Models.Entities.Trait>("rage", Traits.Instances.Rage.ID)} trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50a72d4d-3f88-4f0b-a473-7a98539866f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
