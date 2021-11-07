using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CleverShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("e0bac846-14e4-4f5f-90de-9afe3cdd659a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clever Shadow",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d0edc70-46ef-4047-867c-7ba05de804ef"), Type = TextBlockType.Text, Text = "You can perform simple (action: Interact) actions with your shadow, such as opening an unlocked door. Anything your shadow (action: Interacts | Interact) with must be within your reach. Your shadow can’t perform actions that require significant manual dexterity, including any action that would require a check to accomplish, and you can’t use it to hold items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7d6523b-62dc-470d-82b2-b92d82601079"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
