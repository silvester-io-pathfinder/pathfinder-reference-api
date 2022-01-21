using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class AlchemicalExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("e5e551cd-d689-40c5-82aa-dd586bf95a47");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Alchemical Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("918a6c4b-8bb5-4246-b224-bb0b040e0e31"), Type = TextBlockType.Text, Text = "Constant practice has increased the effectiveness of your concoctions. Your proficiency rank for your alchemist class DC increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("e61bb88b-2043-439f-8eeb-e16aca639883"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec7f5f06-9ae7-4f4e-894f-22f65ad4d422"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 76
            };
        }
    }
}
