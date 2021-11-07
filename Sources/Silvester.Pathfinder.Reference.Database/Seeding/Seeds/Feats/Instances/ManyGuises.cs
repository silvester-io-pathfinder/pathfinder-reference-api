using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManyGuises : Template
    {
        public static readonly Guid ID = Guid.Parse("4c1d4e36-ec3e-4b2e-b86d-a79ad668cdda");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Many Guises",
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
            yield return new TextBlock { Id = Guid.Parse("13c36e72-2010-44fa-853c-5dbe435ea41d"), Type = TextBlockType.Text, Text = "You can take on any number of mundane guises. Whenever you change your identity, instead of taking on your social or vigilante identity, you can become someone completely ordinary. This identity isn’t a specific individual – rather, you become a nondescript member of your ancestry, of any gender, with a neutral alignment and a mundane occupation such as common laborer, farmer, or peasant. Spells and abilities detect you as if you were this ordinary identity, rather than either of your two real identities, unless they succeed at a counteract check against your Deception DC. You can’t use either (trait: social) abilities or (trait: vigilante) abilities while in this identity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("28bc2d14-a8e9-47a4-a805-d92aaaa38d8d"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("764c4706-0a1b-47de-a8f5-9b97d02ff4db"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3e0c89c-db3b-413e-9481-1a59bbd442ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
