using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HideousUlulation : Template
    {
        public static readonly Guid ID = Guid.Parse("1c0b23a9-45dc-439a-9720-ff9c0425aa9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hideous Ululation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f9140b65-dcbc-4cf1-9ed5-9ae725eb3826"), Type = TextBlockType.Text, Text = "Your throat has multiple separate chambers that can give your voice an eerie echo. You can be clearly heard at distances of up to 300 feet regardless of ambient sound, although your voice doesn't penetrate a magical silence effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("207dd430-4eed-4532-bf5e-c55f8eb3ec84"), Feats.Instances.OozemorphDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8580e059-993a-4bd2-b8db-04549ac7203e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d8fca20-15fd-4728-b3d8-d9b9963adec5"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
