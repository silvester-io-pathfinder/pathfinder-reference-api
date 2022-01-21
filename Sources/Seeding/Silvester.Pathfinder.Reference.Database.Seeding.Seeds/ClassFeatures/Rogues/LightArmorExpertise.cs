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
    public class LightArmorExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("f9b12ec6-99a9-4e95-9c83-31f7140c3caa");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Light Armor Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9967bfe0-72ca-496e-bede-691888368747"), Type = TextBlockType.Text, Text = "You've learned how to dodge while wearing light or no armor. Your proficiency rank for light armor and unarmored defense increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("490a436f-ab43-40a2-98b2-973a4bfa7a15"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("d12ec8e0-896e-46c5-b482-13cfc36d397a"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e891ea9d-5061-4226-8778-5872349686ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 182
            };
        }
    }
}
