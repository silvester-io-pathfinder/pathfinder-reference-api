using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class Devastator : Template
    {
        public static readonly Guid ID = Guid.Parse("083510e5-f27c-4d72-b5a7-a8fca02aec25");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Devastator", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ad19c0d3-a101-4850-9e8c-1603526ab0b0"), Type = TextBlockType.Text, Text = "Your Strikes are so devastating that you hardly care about resistance, and your barbarian abilities are unparalleled. Your proficiency rank for your barbarian class DC increases to master. Your melee Strikes ignore 10 points of a creature's resistance to their physical damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("dd3de0dc-05ac-43b3-a5a9-7f8a037f0b4a"), Proficiencies.Instances.Master.ID);
            //TODO: Add -10 to resistance effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b44f917-8d15-4eaa-84b1-ec4415af15f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
