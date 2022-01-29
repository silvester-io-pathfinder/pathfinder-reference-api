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
    public class ScholasticIdentification : Template
    {
        public static readonly Guid ID = Guid.Parse("0fe892cf-8196-462e-8c18-4e6e9168ce22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scholastic Identification",
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
            yield return new TextBlock { Id = Guid.Parse("4a186371-b35f-48f1-ad0b-56017cd03783"), Type = TextBlockType.Text, Text = $"You have the knowledge needed to understand ancient texts and cultural artifacts. You can use Society when {ToMarkdownLink<Models.Entities.SkillAction>("Deciphering Writing", SkillActions.Instances.DecipherWriting.ID)}, no matter the type of writing you are examining. You can also use Society to {ToMarkdownLink<Models.Entities.SkillAction>("Identify Magic", SkillActions.Instances.IdentifyMagic.ID)} when examining a magic item or location with cultural significance." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cab186e5-9173-440e-9c93-e7c5d252e39a"), Feats.Instances.ArchaeologistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("c701c9d6-39a9-4988-b716-7b00c1d950de"), Proficiencies.Instances.Master.ID, Skills.Instances.Society.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f7abff21-a7a5-48bf-a454-746454b9a791"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("2821aa72-7997-4570-aaf8-f1928fbe9c81"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29fe072d-9e32-4529-ba45-d963e7abb136"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
