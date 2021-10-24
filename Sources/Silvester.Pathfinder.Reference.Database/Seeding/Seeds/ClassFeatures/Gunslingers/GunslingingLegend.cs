using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class GunslingingLegend : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 13,
                Name = "Gunslinging Legend", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've learned unique techniques for wielding firearms and crossbows that give you unmatched skill in their use. Your proficiency rank increases to legendary with simple and martial firearms and crossbows and to master with advanced firearms and crossbows. Your proficiency rank for simple weapons, martial weapons, and unarmed attacks increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Crossbow.ID, WeaponCategories.Instances.Advanced.ID);
            builder.GainSpecificWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, WeaponGroups.Instances.Firearm.ID, WeaponCategories.Instances.Advanced.ID);

            builder.GainAnyWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Simple.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Martial.ID);
            builder.GainAnyWeaponGroupProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);

            builder.GainSpecificWeaponGroupSpecialization(Guid.Parse(""), WeaponGroups.Instances.Crossbow.ID);
            builder.GainSpecificWeaponGroupSpecialization(Guid.Parse(""), WeaponGroups.Instances.Firearm.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
