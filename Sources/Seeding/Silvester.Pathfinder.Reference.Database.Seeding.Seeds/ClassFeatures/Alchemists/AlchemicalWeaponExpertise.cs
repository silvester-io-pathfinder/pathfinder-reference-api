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
    public class AlchemicalWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("d52bc13e-5744-425b-922b-aa5e85f3fcd4");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Alchemical Weapon Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1fb5d1d0-957a-4b15-adb8-9724aac19fe9"), Type = TextBlockType.Text, Text = "you've trained to more effectively wield the weapons you find in your lab.Your proficiency ranks for simple weapons, alchemical bombs, and unarmed attacks increase to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("0f619836-9df1-4e3a-8cea-b7497bb32346"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponCategoryProficiency(Guid.Parse("c1302f00-d2b0-4797-bfd8-c2b14576406f"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            builder.GainSpecificAlchemicalBombProficiency(Guid.Parse("edef87f8-f614-4073-a61a-aa84e0324387"), Proficiencies.Instances.Expert.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4966e4ad-0375-471c-bb2d-7671a209ec26"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 74
            };
        }
    }
}
