using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Assurance : Template
    {
        public static readonly Guid ID = Guid.Parse("b5e97747-9edc-41e7-9236-39a146214bd4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Assurance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time, choose a different skill and gain the benefits for that skill.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a61c0c7-9bfe-482d-b3c7-227b9ab0194b"), Type = TextBlockType.Text, Text = "Even in the worst circumstances, you can perform basic tasks. Choose a skill you’re trained in. You can forgo rolling a skill check for that skill to instead receive a result of 10 + your proficiency bonus (do not apply any other bonuses, penalties, or modifiers)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnySkillProficiency(Guid.Parse("8576b8c7-a684-45b1-a5be-8d8d3a96ea4a"), Proficiencies.Instances.Trained.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54625ce4-1036-4a3d-8c1c-28e1492c4dd8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
