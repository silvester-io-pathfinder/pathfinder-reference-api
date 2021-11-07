using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryLinguist : Template
    {
        public static readonly Guid ID = Guid.Parse("fbe3a73b-d096-4431-98fe-fe76c3174538");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Linguist",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70963df6-33e5-45ee-89ff-4e881850c859"), Type = TextBlockType.Text, Text = "You’re so skilled with languages you can create a pidgin instantly. You can always talk to any creature that has a language – even a language you don’t know – by creating a new pidgin language that uses simplified terms and conveys basic concepts. To do so, you must first understand at least what medium of communication the creature uses (speech, sign language, and so on)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f8a654f5-edaf-4203-b99b-822045873b86"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("5d2c6ac4-4b3f-4e28-b754-a57337fe5d1d"), Feats.Instances.Multilingual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81129094-63a1-4581-8c2b-faf8e73ba69b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
