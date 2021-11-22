using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhoneticTraining : Template
    {
        public static readonly Guid ID = Guid.Parse("4ab1bcc1-a20a-4ba7-9241-b4d76c50fc19");

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
            yield return new TextBlock { Id = Guid.Parse("b550ff32-8764-4b95-8b00-041657f1c6b4"), Type = TextBlockType.Text, Text = "You can pronounce and repeat words with near-perfect accuracy even if you don't understand their meaning, and you can write them down in a phonetic script that allows you or another creature with Phonetic Training to read it later. Even if the words are in a language with sound you can't pronounce, you can faithfully transcribe them. Memorizing long sequences of words remains just as difficult as it is normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("10a6fda2-98e6-4c66-8262-39357487c761"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("2d96f1c6-4d88-47d7-a265-376e53fe20bd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("622df9e8-e662-40a5-95ed-3ec4de1c88bf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
