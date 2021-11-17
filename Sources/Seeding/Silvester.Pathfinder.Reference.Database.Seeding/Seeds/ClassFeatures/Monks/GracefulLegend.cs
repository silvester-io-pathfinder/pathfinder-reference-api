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
    public class GracefulLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("aa1cbafb-654a-413b-ba4a-e444d98af778");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Graceful Legend", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2308487f-9375-4e23-8a31-04f56517f9d5"), Type = TextBlockType.Text, Text = "Your sublime movement grants you unparalleled protection and offense. Your proficiency rank for unarmored defense increases to legendary, and your proficiency rank for your monk class DC increases to master. If you have ki spells, your proficiency rank for spell attack rolls and spell DCs with the tradition of magic you use for your ki spells increases to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("814550bd-62b3-4553-af23-3d61bbe74f63"), Proficiencies.Instances.Legendary.ID, ArmorCategories.Instances.Unarmored.ID);
            builder.GainSpecificClassDcProficiency(Guid.Parse("b7bc3726-dffb-477d-9457-3b520b0600cc"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("29278976-92bf-4c36-adb6-cf820e03b4e6"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("c4c52135-7eef-41cb-99ef-2d18e58300bc"), Proficiencies.Instances.Master.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a573bca-d52d-4def-aed8-05e40fe0c7d0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 158
            };
        }
    }
}
