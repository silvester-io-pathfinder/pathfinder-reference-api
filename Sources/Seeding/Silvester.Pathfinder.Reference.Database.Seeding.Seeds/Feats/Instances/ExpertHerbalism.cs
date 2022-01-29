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
    public class ExpertHerbalism : Template
    {
        public static readonly Guid ID = Guid.Parse("ce3bc793-d745-4126-827f-49925edb77a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Herbalism",
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
            yield return new TextBlock { Id = Guid.Parse("a0ce2657-1523-4659-9fba-17765c936312"), Type = TextBlockType.Text, Text = $"Your advanced alchemy level for herbalism increases to your level – 3. You gain the formulas for elixirs of life as soon as your advanced alchemy level is high enough to create them: lesser at 8th level, moderate at 12th level, greater at 16th level, and major at 18th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9bcc6bf7-2873-4bdd-b372-a6c2bdb4ab58"), Feats.Instances.HerbalistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f75ee4c5-2eea-47e4-8c82-aa34ae7eaafd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d75be90c-0703-4ef9-9aab-eb5bd737a70f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
