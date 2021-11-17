using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class ExpertStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("29308327-831b-42e4-9833-deae288c6046");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Expert Strikes", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1fa4676c-f668-4ba2-a2ca-1f8492cd7c74"), Type = TextBlockType.Text, Text = "You�ve practiced martial arts and have now surpassed your former skill. Your proficiency ranks for unarmed attacks and simple weapons increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("890a4334-0ce2-471a-8875-61caacd9bb30"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("f806c1b6-7c44-4fc2-ab31-aad5acca73d7"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57f4d698-c064-4c5b-b0a5-451f7962f703"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
