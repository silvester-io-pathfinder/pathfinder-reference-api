using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForcedEntry : Template
    {
        public static readonly Guid ID = Guid.Parse("de87739b-4064-400c-9680-ad879df8b97e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forced Entry",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("546f2391-ec1c-4c16-ae65-20b12fe1acd2"), Type = TextBlockType.Text, Text = "You are trained to preserve the archaeological value of your location when entering. You don't take a penalty to (action: Force Open) doors, windows, or containers without a (item: crowbar). If you roll a success on a check to (action: Force Open), you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e4735a2e-4b06-476c-999a-28b9ad6f4259"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("be5b2ff1-dac9-4251-a8c4-05d242a47adb"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ac1b8a1-b6df-4bec-bec4-3dfac2faa055"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
