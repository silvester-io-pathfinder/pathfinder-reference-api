using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LastingCoercion : Template
    {
        public static readonly Guid ID = Guid.Parse("2612a304-13d4-48ca-a967-918a0611caa3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lasting Coercion",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cc24178-651d-413b-9bed-d2df71387ca1"), Type = TextBlockType.Text, Text = "When you successfully (action: Coerce) someone, the maximum time they comply increases to a week, still determined by the GM. If you’re legendary, the maximum increases to a month." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("34649e30-9bfe-4e64-94c2-8436d9f64d3e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4203ce4f-24b0-46f3-b57f-8fc2572f1987"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
