using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuskwalkerMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("5822d3af-3603-491a-a3cc-7240b58bd9f7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duskwalker Magic",
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
            yield return new TextBlock { Id = Guid.Parse("9456adc6-db05-4a89-8a57-668ebe1c9d8c"), Type = TextBlockType.Text, Text = "Your connection to psychopomps gives you the power to glimpse the near future and protect corpses from the ravages of undeath. You can cast (spell: augury) and (spell: gentle repose) each once per day as 2nd-level divine innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("946c763a-4c73-4fcd-bbff-9c778bb3a53a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
