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
    public class RecollectStudies : Template
    {
        public static readonly Guid ID = Guid.Parse("a3a03b60-a072-4326-8fab-9d2f03f98927");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recollect Studies",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("752248f7-52f5-4b1b-99e2-75323dcd94d7"), Type = TextBlockType.Text, Text = $"You paid attention during your studies and remember the right way to attack various creatures. Choose a creature that meets the requirements. You learn the resistances, immunities, or weaknesses of the creature (your choice) without needing to successfully {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cd1f4a50-fe83-479e-a8f3-15248f3f6e99"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificRecallKnowledgeProficiency(Guid.Parse("e594bac1-9038-437d-bdba-cab2c61bddc8"), Proficiencies.Instances.Expert.ID, requiresAssurance: false);
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
                Id = Guid.Parse("42bc9483-94ce-41ee-97f4-51aa00035fd8"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
