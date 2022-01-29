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
    public class EagleEye : Template
    {
        public static readonly Guid ID = Guid.Parse("2d340162-6cbc-42a9-a080-0ffc6fe6afd9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eagle Eye",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("693ea31b-7a90-4794-adc1-a668a8046c90"), Type = TextBlockType.Text, Text = $"Your practice with crossbows and firearms has sharpened your attention to detail. You become a master in Perception." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("49a86c3f-c343-4fc5-baad-6a9d083fba09"), Feats.Instances.GunslingerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a1834139-661a-4d71-8af1-075fb97f975f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("80f8940f-89ae-4c56-9342-d21638d7e7cf"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a7a70dc-eef9-442c-8280-2b4b99d7acef"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
