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
    public class EmergencyMedicalAssistance : Template
    {
        public static readonly Guid ID = Guid.Parse("ff6e58c9-a7a9-495e-8a2d-4934198f5def");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emergency Medical Assistance",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd57b92e-5f79-484d-aa03-69a6db14628c"), Type = TextBlockType.Text, Text = $"You've learned a variety of methods for helping allies who are bleeding, burning, or otherwise suffering persistent damage, from brushing off acid to patting down fires. Your ally immediately attempts a flat check to remove all types of persistent damage, and your use of this feat automatically counts as especially effective aid, reducing the DC from 15 to 10 for all future flat checks to remove the persistent damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7fea9e9a-ce23-4faf-bb34-5e74c9f8d56d"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("c499b86b-0462-4652-b5dd-ac5c0840d345"), Proficiencies.Instances.Master.ID, Skills.Instances.Medicine.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f01eddc-2050-4163-8ec3-871a1a61357a"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
