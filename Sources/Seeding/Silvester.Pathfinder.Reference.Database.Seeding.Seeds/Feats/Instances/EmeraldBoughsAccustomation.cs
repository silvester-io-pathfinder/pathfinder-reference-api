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
    public class EmeraldBoughsAccustomation : Template
    {
        public static readonly Guid ID = Guid.Parse("0cb1b1f4-3116-40ae-a21f-18d495e68e25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emerald Boughs Accustomation",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8e89978-525a-47af-bcb0-ba2a690e0892"), Type = TextBlockType.Text, Text = $"You are comfortable and socially capable in almost any cultural context. When you use the Society skill to {ToMarkdownLink<Models.Entities.SkillAction>("Subsist", SkillActions.Instances.Subsist.ID)}, if you roll a critical failure, you get a failure instead; if you roll a success, you get a critical success instead; and if you roll a critical success, you can provide for another additional creature. Furthermore, when you attempt a Society check to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} about cultural practices and roll a critical failure, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c5d1ee7e-260a-44f3-8caa-b48092676d3a"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("79d87c2c-5ec4-473c-8b7f-bb3e660a5012"), "Emerald Boughs affiliation.");
            builder.HaveSpecificSkillProficiency(Guid.Parse("a272fc54-9d1f-4d79-b2a3-66eca4597c14"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
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
                Id = Guid.Parse("df0828f1-0536-4b03-bcc8-f638afe9dea9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
