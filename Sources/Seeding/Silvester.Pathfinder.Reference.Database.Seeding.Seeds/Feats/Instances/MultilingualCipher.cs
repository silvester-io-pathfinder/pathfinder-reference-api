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
    public class MultilingualCipher : Template
    {
        public static readonly Guid ID = Guid.Parse("f236e29d-5aae-4ef0-8bab-9db41ccb8b0f");

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
            yield return new TextBlock { Id = Guid.Parse("f8fd95da-b1e5-440d-91f8-408481bad3ff"), Type = TextBlockType.Text, Text = $"You use multiple languages to create and break codes. You gain a +1 circumstance bonus to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)}. If another creature attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)} you encoded, they take a -2 circumstance penalty unless they speak all the languages you used when you created the writing." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f5b377dd-6b91-4589-b1d2-6793853baa1e"), Feats.Instances.LinguistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("2e301ae3-698e-4b45-9dfa-8918ab41cb24"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24aa6fc6-85b3-4a9f-86a8-021bab5a0959"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
