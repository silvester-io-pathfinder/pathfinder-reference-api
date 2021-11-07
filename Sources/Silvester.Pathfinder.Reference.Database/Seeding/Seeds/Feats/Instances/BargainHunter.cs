using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BargainHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("0fcf35d9-3516-4bb7-8b47-40019907fa4f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bargain Hunter",
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
            yield return new TextBlock { Id = Guid.Parse("cd963094-e4ae-419f-98c6-ed96ea321ed7"), Type = TextBlockType.Text, Text = "You can (action: Earn Income) using Diplomacy, spending your days hunting for bargains and reselling at a profit. You can also spend time specifically sniffing out a great bargain on an item; this works as if you were using (action: Earn Income) with Diplomacy, except instead of gaining money, you purchase the item at a discount equal to the money you would have gained, gaining the item for free if your earned income equals or exceeds its cost. Finally, if you select Bargain Hunter during character creation at 1st level, you start play with an additional 2 gp." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("401a6234-3d29-470c-922f-06cf420e780b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("212e9655-587a-44e4-ba4a-0701aca845e4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
