using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhysicalTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("b3a03b8f-fc1f-4e62-8c2e-e2f48fcf0464");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Physical Training",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55f30682-a4e0-4feb-a58a-f6e9dd2f92d3"), Type = TextBlockType.Text, Text = "You spend a lot of time focusing on your physical fitness. You increase your proficiency rank in Acrobatics and Athletics from expert to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6718804c-ae9c-4ee8-8689-4c3eb4cee172"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8799b6f7-3b7c-431b-b62c-9fbc9c49d7b5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("64f47b0d-5c8b-4128-96d8-932ba639146e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43d9e55a-0e59-42cb-9071-f601041a733d"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
