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
    public class LegendaryArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("121a09b6-05f9-4374-ab06-6ae176b9217f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Legendary Armor", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a559dcf6-ae3d-4022-9663-2907d2203439"), Type = TextBlockType.Text, Text = "You shield yourself with steel as easily as with faith. Your proficiency ranks for light, medium, and heavy armor, as well as for unarmored defense, increase to legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("c5fe27cf-bc98-47ff-8e4d-c4a4deddb0ee"), Proficiencies.Instances.Legendary.ID, ArmorCategories.Instances.LightArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("37dac52f-2a35-4b63-a750-5ea79b748563"), Proficiencies.Instances.Legendary.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("d15034ac-0991-460b-84c2-462acfc2621b"), Proficiencies.Instances.Legendary.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("572c5a64-907b-48d7-a845-d7037e21c1ee"), Proficiencies.Instances.Legendary.ID, ArmorCategories.Instances.Unarmored.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09c1c000-17a6-4ed0-9083-f83de2b060a9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
