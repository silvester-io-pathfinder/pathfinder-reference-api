using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CunningHair : Template
    {
        public static readonly Guid ID = Guid.Parse("08629303-b146-4400-821b-3a2bffc06aa5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cunning Hair",
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
            yield return new TextBlock { Id = Guid.Parse("46ef7dbc-ab1f-4ce1-9a2e-f633e098425f"), Type = TextBlockType.Text, Text = "Your hair moves under your control. You can perform simple (action: Interact) actions with your hair, such as opening an unlocked door. Your hair can’t perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish, and you can’t use it to hold items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6d49ec6-3d96-4888-830e-3e744c2fff5b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
