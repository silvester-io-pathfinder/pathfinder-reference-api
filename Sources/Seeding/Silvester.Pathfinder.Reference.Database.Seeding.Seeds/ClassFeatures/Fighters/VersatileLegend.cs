using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class VersatileLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("ada548da-bbf4-4565-8e2f-4dc5ac90b7d9");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Versatile Legend", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c717e889-4691-4b4e-87b9-bdffe5c72e56"), Type = TextBlockType.Text, Text = "You are nigh-unmatched with any weapon. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to legendary, and your proficiency rank for advanced weapons increases to master. Your proficiency rank for your fighter class DC increases to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("fc3f1ef2-f4b8-4746-bedc-d328c6feeaf0"), Proficiencies.Instances.Legendary.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("8381d732-5faa-4463-bf50-adb822f1144b"), Proficiencies.Instances.Legendary.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("9423dfc2-73cd-4d8f-9ae2-9c47efdaa49c"), Proficiencies.Instances.Legendary.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("50739ebb-d438-469f-af97-13b163aa90aa"), Proficiencies.Instances.Master.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainSpecificClassDcProficiency(Guid.Parse("2d2757b2-5e46-4f79-b9ae-b64b64582da2"), Proficiencies.Instances.Master.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ce99131-5bf3-45ff-8ba5-6a98784af58c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 144
            };
        }
    }
}
