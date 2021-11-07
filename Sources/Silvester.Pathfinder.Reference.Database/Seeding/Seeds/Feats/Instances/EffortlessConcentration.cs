using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EffortlessConcentration : Template
    {
        public static readonly Guid ID = Guid.Parse("2b50b320-0b69-45b7-89b8-8bddf4ea1770");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Effortless Concentration",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d813e21a-0ea6-4f6e-a1fb-34eff524c8cb"), Type = TextBlockType.Text, Text = "You maintain a spell with hardly a thought. You immediately gain the effects of the (action: Sustain a Spell) action, allowing you to extend the duration of one of your active spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1af0465a-2bbf-4723-b987-5f64d43cd6f5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
