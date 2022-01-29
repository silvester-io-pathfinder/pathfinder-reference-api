using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecretSpeech : Template
    {
        public static readonly Guid ID = Guid.Parse("108c56b5-09cc-4ad0-a8fd-936442a1914c");

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
            yield return new TextBlock { Id = Guid.Parse("90e7927b-c866-4103-ab38-3be48562a80b"), Type = TextBlockType.Text, Text = $"~ Access: Have earnt Mialari Docur's trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("6a65fdd2-91b3-4187-acce-2bfc547e2217"), Type = TextBlockType.Text, Text = $"Choose a secret society (such as the Lacunafex or the Bellflower Network). You've learned that society's secret cant or jargon, enabling you to share hidden messages when signing or speaking with others who've also learned it. If an observer succeeds at a Perception check against your Deception DC when you do this, they realize you are passing a message but fail to discern its content, unless they subsequently succeed at a Society check against your Deception DC. On a critical success, they learn not only the message, but also who you're passing the message to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0a348742-a758-4dfd-b188-ba63f39ee408"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d55f47b1-47da-4c24-9fa4-fa89816f7277"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
