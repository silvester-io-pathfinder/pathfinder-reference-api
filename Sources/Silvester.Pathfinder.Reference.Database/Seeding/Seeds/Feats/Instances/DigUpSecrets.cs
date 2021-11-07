using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DigUpSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("12b398b1-6ec8-433f-9dc4-c9706f77edb5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dig Up Secrets",
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
            yield return new TextBlock { Id = Guid.Parse("771f2523-c838-4735-9dee-baae43d11813"), Type = TextBlockType.Text, Text = "You are an endless well of knowledge and can remember several vital pieces of information at once. You can cast (spell: hypercognition) as an innate occult spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4751561-4a59-4e10-8090-5fd01c454356"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
