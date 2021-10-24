using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Doctrines.Instances
{
    public class CloisteredCleric : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Doctrine GetDoctrine()
        {
            return new Doctrine
            {
                Id = ID,
                Name = "Cloistered Cleric",
                Description = "You are a cleric of the cloth, focusing on divine magic and your connection to your deity’s domains."
            };
        }

        public override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DomainInitiate.ID)
                .Name("First Doctrine");

            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 3);
                })
                .Name("Second Doctrine");

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Third Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 7);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID);
            });

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Fourth Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11);
                });
                and.GainDeityFavoredWeaponProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID);
                and.GainDeityFavoredWeaponSpecialization(Guid.Parse(""));
            });

            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Fifth Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID);
            }); 
            
            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.Name("Final Doctrine");
                and.AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 19);
                });
                and.GainSpecificSpellAttackProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID);
                and.GainSpecificSpellDcProficiency(Guid.Parse(""), Proficiencies.Instances.Legendary.ID);
            });
        }

        public override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 119
            };
        }
    }
}
