using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShaitanMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("af7a2ba6-6918-4908-8416-5980fe82053f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shaitan Magic",
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
            yield return new TextBlock { Id = Guid.Parse("f94f09e4-5ced-46eb-8d8c-133594b29b06"), Type = TextBlockType.Text, Text = "The magic of shaitans runs through your blood. You can cast (spell: glitterdust) and (spell: resist energy) once per day each as 2nd-level arcane innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce468661-b234-4a93-b66b-53b90d7b0227"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
