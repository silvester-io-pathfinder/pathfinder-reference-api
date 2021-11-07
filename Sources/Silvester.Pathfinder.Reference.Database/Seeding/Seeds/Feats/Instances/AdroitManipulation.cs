using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdroitManipulation : Template
    {
        public static readonly Guid ID = Guid.Parse("2e60611f-bebf-411d-9b21-7b92f4e031c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adroit Manipulation",
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
            yield return new TextBlock { Id = Guid.Parse("8757119a-1220-4899-8af7-b490a29fa028"), Type = TextBlockType.Text, Text = "~ Access: Mihrini ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("b73faa16-5ff9-4c6b-bd7e-dd87256de5de"), Type = TextBlockType.Text, Text = "You’ve fiddled with knots, locks, and blacksmith’s puzzles since you were a child to give your hands something to do. You gain the trained proficiency rank in Thievery (or another skill of your choice, if you’re already trained in Thievery). If you roll a success on a Thievery check to (action: Pick a Lock), you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae2e4371-616c-4354-a89e-f132844802bb"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
