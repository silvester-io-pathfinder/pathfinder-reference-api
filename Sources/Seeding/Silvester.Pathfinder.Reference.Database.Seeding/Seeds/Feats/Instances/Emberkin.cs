using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Emberkin : Template
    {
        public static readonly Guid ID = Guid.Parse("8b544b0a-9cb8-4434-a24b-4a6f708dd635");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emberkin",
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
            yield return new TextBlock { Id = Guid.Parse("258de82a-5fa9-4bd5-8153-90fec9c37c9b"), Type = TextBlockType.Text, Text = "A peri's roaring spirit burns in your soul. Peris engage in constant struggle to right the wrongs of their fallen forebears, and that struggle has been passed on to you. You have a direct impulse to right wrongs and better the world. You gain a +1 circumstance bonus to saving throws against (trait: fire) effects, and your perception is unaffected by non-magical flames, fog and smoke." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c9a2563-de01-4dc2-a707-d259cbc87fc4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
