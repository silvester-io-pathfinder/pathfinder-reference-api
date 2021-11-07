using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalcyonSpellcastingInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("dca88a32-b505-4bfb-ba5a-0fbb6613131b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Spellcasting Initiate",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b392340e-0d95-46c6-8ac0-54383b209fc5"), Type = TextBlockType.Text, Text = "Your knowledge of halcyon magic increases. You gain two common 2nd-level halcyon spells and two 3rd-level halcyon spells. You also gain a 2nd-level halcyon spell slot and a 3rd-level halcyon spell slot. These and all future halcyon spell slots work like the 1st-level halcyon spell slot you gained from (feat: Halcyon Speaker Dedication)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0cb10d9a-88ba-4fe9-8211-a96cdfbcc254"), Feats.Instances.HalcyonSpeakerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("855ef08b-662c-4c6e-b350-8e90abb1fa14"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
