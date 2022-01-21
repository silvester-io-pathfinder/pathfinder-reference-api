using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class IncredibleSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("e0e7b4cc-9a29-4614-88d0-ab4681752941");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Incredible Senses", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c9746fe0-69c1-4c1a-9286-0a73eaece8ec"), Type = TextBlockType.Text, Text = "You notice things almost impossible for an ordinary person to detect. Your proficiency rank for Perception increases to legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("4ae4cc0d-fddd-4854-a36c-362ea1c1bdb0"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Perception.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ff33331-443e-40ec-aef4-c0a91c3c7e54"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 182
            };
        }
    }
}
