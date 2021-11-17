using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkillfulTail : Template
    {
        public static readonly Guid ID = Guid.Parse("78309a03-1949-49d5-a5c2-6e05c4bec011");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skillful Tail",
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
            yield return new TextBlock { Id = Guid.Parse("3e0d63ab-57a8-4b7f-b238-9e3c84f18d19"), Type = TextBlockType.Text, Text = "You were born with a tail, and with practice you’ve learned how to perform simple (action: Interact) actions with it, such as opening an unlocked door. Your tail can’t perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish, and you can’t use it to hold items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61ab137a-ad03-40b3-875b-f99f28bb82d3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
