using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickRecognition : Template
    {
        public static readonly Guid ID = Guid.Parse("e2193fde-7ebc-4cd6-8729-c9e5cce2afc7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Recognition",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a0c23d5a-486f-4845-8321-1d1a57805e25"), Type = TextBlockType.Text, Text = "You (action: Recognize Spells | Recognize Spell) swiftly. Once per round, you can (action: Recognize a Spell | Recognize Spell) using a skill in which you’re a master as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("5306b363-1400-4021-b6bc-7239f83b2cbd"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("7ca61963-17b7-4777-a1f6-641259f1bf98"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("db988f55-8231-4d9c-837e-12eadbf39f47"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("e05cdda4-3e21-4280-b60a-a6dd285aed50"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("feeec656-96d5-4b2a-93f8-2b87ec30debb"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("26dd7fcd-88bc-4097-914c-7c1eec55e35a"), Feats.Instances.RecognizeSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d5d5adf-b393-4bd1-b56b-52e69336750a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
