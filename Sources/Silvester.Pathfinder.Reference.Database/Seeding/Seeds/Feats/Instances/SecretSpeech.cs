using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecretSpeech : Template
    {
        public static readonly Guid ID = Guid.Parse("4a94f169-5d3e-448e-bb37-8a389d6b9b76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Secret Speech",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat multiple times. You learn the secret speech of a different society each time.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("597f5bf2-1eb5-4d39-999b-9389c8345bc9"), Type = TextBlockType.Text, Text = "~ Access: Have earnt Mialari Docur’s trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("cba37747-161a-42b9-ae5b-e8d0ab1e69d0"), Type = TextBlockType.Text, Text = "Choose a secret society (such as the Lacunafex or the Bellflower Network). You’ve learned that society’s secret cant or jargon, enabling you to share hidden messages when signing or speaking with others who’ve also learned it. If an observer succeeds at a Perception check against your Deception DC when you do this, they realize you are passing a message but fail to discern its content, unless they subsequently succeed at a Society check against your Deception DC. On a critical success, they learn not only the message, but also who you’re passing the message to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e6cdcd06-333d-4a93-a6ce-a777beb6fd63"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9ea5cdb-bdb6-41ab-8c75-b4a11ba82617"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
