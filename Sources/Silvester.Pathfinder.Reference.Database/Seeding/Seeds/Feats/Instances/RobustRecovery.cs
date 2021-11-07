using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RobustRecovery : Template
    {
        public static readonly Guid ID = Guid.Parse("9afc9c57-0b57-455c-8092-71abfc3dc87d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Robust Recovery",
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
            yield return new TextBlock { Id = Guid.Parse("9ce00c37-ba9e-4ce8-b90b-5bc84db6558d"), Type = TextBlockType.Text, Text = "You learned folk medicine to help recover from diseases and poison, and using it diligently has made you especially resilient. When you (Action: Treat a Disease | Treat Disease) or (Action: Treat a Poison | Treat Poison), or someone else uses one of these actions on you, increase the circumstance bonus granted on a success to +4, and if the result of the patient’s saving throw is a success, the patient gets a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("de54ce4b-f11a-4e7e-83b8-8509d1b8b6b5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3be4b9b-2176-4c86-96ef-003fd424a447"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
