using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhoneticTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("f8cd8506-e176-4ac5-b164-df534659f271");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phonetic Training",
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
            yield return new TextBlock { Id = Guid.Parse("e84ee65c-4276-437b-a2e6-3b74406750fa"), Type = TextBlockType.Text, Text = "You can pronounce and repeat words with near-perfect accuracy even if you don’t understand their meaning, and you can write them down in a phonetic script that allows you or another creature with Phonetic Training to read it later. Even if the words are in a language with sound you can’t pronounce, you can faithfully transcribe them. Memorizing long sequences of words remains just as difficult as it is normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("60d0514f-ce35-4f3f-8b5d-6cdb5d662502"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ee9d3f1e-322a-44c9-ad04-d7ffa03d0f58"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf806957-34cc-46bd-be22-812d4063dc61"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
