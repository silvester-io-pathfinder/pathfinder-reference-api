using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MultilingualCipher : Template
    {
        public static readonly Guid ID = Guid.Parse("26ea7a29-20d9-4f11-b1fd-2d0dba37581c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multilingual Cipher",
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
            yield return new TextBlock { Id = Guid.Parse("c02b0d6a-fe0d-4e2e-9356-4d2bc9086804"), Type = TextBlockType.Text, Text = "You use multiple languages to create and break codes. You gain a +1 circumstance bonus to (action: Decipher Writing). If another creature attempts to (action: Decipher Writing) you encoded, they take a -2 circumstance penalty unless they speak all the languages you used when you created the writing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aeeea3e4-d611-4169-804e-ce2eaf819e34"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("c5dd6005-bf1b-43c2-9a04-120606932851"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8621e33d-000b-485e-9a86-afbc0654f593"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
