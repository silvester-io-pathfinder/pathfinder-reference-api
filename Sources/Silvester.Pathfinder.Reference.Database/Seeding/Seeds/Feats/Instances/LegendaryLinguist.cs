using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryLinguist : Template
    {
        public static readonly Guid ID = Guid.Parse("8ccc2b0b-6c9e-491e-926b-d797fd855cfb");

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
            yield return new TextBlock { Id = Guid.Parse("d587db7f-b591-499f-b1b1-11d3364af8fd"), Type = TextBlockType.Text, Text = "You’re so skilled with languages you can create a pidgin instantly. You can always talk to any creature that has a language – even a language you don’t know – by creating a new pidgin language that uses simplified terms and conveys basic concepts. To do so, you must first understand at least what medium of communication the creature uses (speech, sign language, and so on)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("af8c1b76-c282-426e-8730-e6593def22fe"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("4a7cc28d-c847-4d6d-afa5-c9f4ca07a2d8"), Feats.Instances.Multilingual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("809cc535-9cba-4372-9c49-d9b7111f31d2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
