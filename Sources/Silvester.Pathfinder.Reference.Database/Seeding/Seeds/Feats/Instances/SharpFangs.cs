using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SharpFangs : Template
    {
        public static readonly Guid ID = Guid.Parse("c3a18a5b-5236-4f2f-81e7-0a8d9327e504");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sharp Fangs",
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
            yield return new TextBlock { Id = Guid.Parse("9b3c1dcc-8ef2-4fe0-bc78-d5b7b0b9931d"), Type = TextBlockType.Text, Text = "Your teeth are formidable weapons. You gain a fangs unarmed attack that deals 1d8 piercing damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fea0f481-6d90-49a0-8102-aadc0c0cdfba"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
