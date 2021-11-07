using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkillfulTail : Template
    {
        public static readonly Guid ID = Guid.Parse("51db551b-0eda-4fd1-8f90-ceb5bba52049");

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
            yield return new TextBlock { Id = Guid.Parse("ed156ac0-df2a-4b7b-a3a4-d4fd418a4e0e"), Type = TextBlockType.Text, Text = "You were born with a tail, and with practice you’ve learned how to perform simple (action: Interact) actions with it, such as opening an unlocked door. Your tail can’t perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish, and you can’t use it to hold items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2f40cc0-7d9d-41fd-bae5-5d246283346d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
