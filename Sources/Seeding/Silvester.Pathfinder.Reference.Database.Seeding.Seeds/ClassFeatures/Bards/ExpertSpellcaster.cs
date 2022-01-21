using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class ExpertSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("b25adfa9-8a9e-4b5c-bdc6-53944081f58b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Expert Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("10956487-a258-4dd6-a27c-c6c273e628c6"), Type = TextBlockType.Text, Text = "Your proficiency ranks for occult spell attack rolls and spell DCs increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("16057a91-1219-483a-8929-03b66e74d9a4"), Proficiencies.Instances.Expert.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("c7cca7a5-b60b-44d6-8ef2-4f3e874e3f4e"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdf4a950-126c-4d26-b336-7419e97d3f10"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 98
            };
        }
    }
}
