using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class SingularExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Singular Expertise", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have particular expertise with guns and crossbows that grants you greater proficiency with them and the ability to deal more damage. You gain a +1 circumstance bonus to damage rolls with firearms and crossbows." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "This intense focus on firearms and crossbows prevents you from reaching the same heights with other weapons. Your proficiency with unarmed attacks and with weapons other than firearms and crossbows can't be higher than trained, even if you gain an ability that would increase your proficiency in one or more other weapons to match your highest weapon proficiency (such as the weapon expertise feats many ancestries have). If you have gunslinger weapon mastery, the limit is expert, and if you have gunslinging legend, the limit is master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponGroupCircumstanceBonus(Guid.Parse(""), WeaponGroups.Instances.Firearm.ID, bonus: 1, RollType.Attack);
            builder.GainSpecificWeaponGroupCircumstanceBonus(Guid.Parse(""), WeaponGroups.Instances.Crossbow.ID, bonus: 1, RollType.Attack);

            builder
                .AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSingularExpertise(Guid.Parse(""), WeaponGroups.Instances.Firearm.ID, Proficiencies.Instances.Trained.ID);
                    and.GainSingularExpertise(Guid.Parse(""), WeaponGroups.Instances.Crossbow.ID, Proficiencies.Instances.Trained.ID);
                })
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.LessThan, requiredLevel: 5);
                });

            builder
                .AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSingularExpertise(Guid.Parse(""), WeaponGroups.Instances.Firearm.ID, Proficiencies.Instances.Expert.ID);
                    and.GainSingularExpertise(Guid.Parse(""), WeaponGroups.Instances.Crossbow.ID, Proficiencies.Instances.Expert.ID);
                })
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.LessThan, requiredLevel: 13);
                });

            builder
              .AddAnd(Guid.Parse(""), and =>
              {
                  and.GainSingularExpertise(Guid.Parse(""), WeaponGroups.Instances.Firearm.ID, Proficiencies.Instances.Master.ID);
                  and.GainSingularExpertise(Guid.Parse(""), WeaponGroups.Instances.Crossbow.ID, Proficiencies.Instances.Master.ID);
              })
              .AddPrerequisites(Guid.Parse(""), prerequisites =>
              {
                  prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
              });
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
