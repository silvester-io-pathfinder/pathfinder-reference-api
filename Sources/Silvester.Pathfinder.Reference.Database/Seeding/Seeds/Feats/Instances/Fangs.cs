using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Fangs : Template
    {
        public static readonly Guid ID = Guid.Parse("f4dbd4b4-7a4b-4ccc-9ecc-aef8d307ee03");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fangs",
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
            yield return new TextBlock { Id = Guid.Parse("93ca5f04-29bd-432e-8769-0498619ddfd0"), Type = TextBlockType.Text, Text = "Your incisors have grown into true fangs: long, sharp, and well-suited to drawing blood. You gain a fangs unarmed attack that deals 1d6 piercing damage. Your fangs are in the brawling group and have the (trait: grapple) and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f676972-9735-4472-b553-4b7340d0df65"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
