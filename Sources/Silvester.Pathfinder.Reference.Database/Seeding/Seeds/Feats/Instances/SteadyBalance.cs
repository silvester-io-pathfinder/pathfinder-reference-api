using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteadyBalance : Template
    {
        public static readonly Guid ID = Guid.Parse("f2aad428-d719-4344-86db-067c3086c597");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steady Balance",
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
            yield return new TextBlock { Id = Guid.Parse("912d1905-b344-4cb1-bef3-4d3486d8035e"), Type = TextBlockType.Text, Text = "You can keep your balance easily, even in adverse conditions. Whenever you roll a success using the (action: Balance) action, you get a critical success instead. You’re not flat-footed while attempting to (action: Balance) on narrow surfaces and uneven ground. Thanks to your incredible balance, you can attempt an Acrobatics check instead of a Reflex save to (action: Grab an Edge)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("dffdb5f5-4693-4525-b457-5e16802e2909"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9f1c71a-f5ff-49a9-9684-ca6d0dc48fde"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
