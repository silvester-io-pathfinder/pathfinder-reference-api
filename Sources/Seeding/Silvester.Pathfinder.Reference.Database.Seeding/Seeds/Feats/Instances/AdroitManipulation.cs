using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdroitManipulation : Template
    {
        public static readonly Guid ID = Guid.Parse("a32d31c3-1a1e-4d64-a14b-f72a6ac91983");

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
            yield return new TextBlock { Id = Guid.Parse("d02a0806-c4e3-49a4-bc01-46da394429e4"), Type = TextBlockType.Text, Text = "~ Access: Mihrini ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("a4f3d524-ca61-461b-9e64-8d4bd828a498"), Type = TextBlockType.Text, Text = "You’ve fiddled with knots, locks, and blacksmith’s puzzles since you were a child to give your hands something to do. You gain the trained proficiency rank in Thievery (or another skill of your choice, if you’re already trained in Thievery). If you roll a success on a Thievery check to (action: Pick a Lock), you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02297c31-ef2f-46bb-910b-0e68f1b8ee0a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
