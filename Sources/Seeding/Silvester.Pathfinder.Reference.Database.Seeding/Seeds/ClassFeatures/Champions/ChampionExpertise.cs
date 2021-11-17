using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class ChampionExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("f4cd3461-029c-4145-8379-4203f6455186");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 9,
                Name = "Champion Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f7f9e50d-e057-48fa-a39e-df7ce475ea4a"), Type = TextBlockType.Text, Text = "Prayers strengthen your divine power. Your proficiency ranks for your champion class DC and divine spell attack rolls and DCs increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("3e0fef63-fb5b-4f77-ad69-993ed6d01730"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("104403df-f900-48eb-8223-2cf7fa955f7f"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("0742568e-4620-4333-bdcc-2a1abf06e69e"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6e12931-bb8c-4e99-9bb3-1f8601a47dd7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
