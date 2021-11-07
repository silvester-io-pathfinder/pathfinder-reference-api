using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrandmothersWisdom : Template
    {
        public static readonly Guid ID = Guid.Parse("3a51a11d-151f-4ad2-9e78-85ee5f058739");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grandmother's Wisdom",
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
            yield return new TextBlock { Id = Guid.Parse("1dc4004d-992f-4d59-8d4e-79c423bc662c"), Type = TextBlockType.Text, Text = "You carry the bones of your ancestors with you, and you can ask them for counsel. You can cast (spell: augury) twice per day as a 2nd-level occult innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3a16e7d-748b-4bad-a6e4-469d4a6d9104"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
