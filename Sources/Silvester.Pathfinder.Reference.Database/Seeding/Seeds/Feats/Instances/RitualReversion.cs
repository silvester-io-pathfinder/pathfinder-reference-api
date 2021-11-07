using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RitualReversion : Template
    {
        public static readonly Guid ID = Guid.Parse("6c92a6bd-8961-4b74-9df0-359f8c4a15ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ritual Reversion",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("842f6c1e-afd8-48c5-a52d-d045507ef6bf"), Type = TextBlockType.Text, Text = "You can temporarily revert to a less conspicuous form without diminishing your senses." };
            yield return new TextBlock { Id = Guid.Parse("93232a05-234e-41df-978e-ac0c79b161fd"), Type = TextBlockType.Text, Text = "You take the form of an ordinary specimen of the type of plant or fungus that most closely resembles you, reverting to your body’s appearance just before your spirit joined with it. This otherwise has the effects of (spell: tree shape), except that your size remains Small." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aced5c97-25df-4cda-a3da-8db98dde8c03"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
