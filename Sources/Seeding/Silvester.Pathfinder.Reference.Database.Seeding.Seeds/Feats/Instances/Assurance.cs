using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Assurance : Template
    {
        public static readonly Guid ID = Guid.Parse("53f5f190-365b-473c-a7c0-3ab61396357d");

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
            yield return new TextBlock { Id = Guid.Parse("cd1462a8-4ce3-495a-8240-67ba1966289e"), Type = TextBlockType.Text, Text = $"Even in the worst circumstances, you can perform basic tasks. Choose a skill you're trained in. You can forgo rolling a skill check for that skill to instead receive a result of 10 + your proficiency bonus (do not apply any other bonuses, penalties, or modifiers)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnySkillProficiency(Guid.Parse("5a8fdb69-7698-4c6c-956c-03f75ee149ad"), Proficiencies.Instances.Trained.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("89c44d29-a00f-4462-ae65-9d72c3c502cb"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("b01e1138-c364-420d-af3e-e512c45c887e"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("08cc0b3b-b310-4273-b74e-72c2b3e8a8b5"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("239503f1-2f16-4392-9fb1-857c08ab5d5c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
