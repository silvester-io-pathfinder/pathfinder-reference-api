using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SensitiveNose : Template
    {
        public static readonly Guid ID = Guid.Parse("b5f2fefc-2449-4d67-bfc7-f9e8cf707754");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sensitive Nose",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain out of this feat or into this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("470fd426-9ba1-4068-9b93-5b3afb6ab525"), Type = TextBlockType.Text, Text = "Your large black nose isn’t just for show. You gain imprecise scent with a range of 30 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac15a262-31b6-4d14-a9be-6d8630449662"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
