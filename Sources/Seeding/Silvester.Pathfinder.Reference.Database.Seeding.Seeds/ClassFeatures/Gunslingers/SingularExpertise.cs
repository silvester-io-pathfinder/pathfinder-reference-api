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
        public static readonly Guid ID = Guid.Parse("505e34bf-1644-42d7-99a9-8a986900dfc2");

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
            yield return new TextBlock { Id = Guid.Parse("556ea568-d253-4191-8c2b-5a024821f155"), Type = TextBlockType.Text, Text = "You have particular expertise with guns and crossbows that grants you greater proficiency with them and the ability to deal more damage. You gain a +1 circumstance bonus to damage rolls with firearms and crossbows." };
            yield return new TextBlock { Id = Guid.Parse("44bdf90b-e8c3-413e-96f3-0a1a21da9dbc"), Type = TextBlockType.Text, Text = "This intense focus on firearms and crossbows prevents you from reaching the same heights with other weapons. Your proficiency with unarmed attacks and with weapons other than firearms and crossbows can't be higher than trained, even if you gain an ability that would increase your proficiency in one or more other weapons to match your highest weapon proficiency (such as the weapon expertise feats many ancestries have). If you have gunslinger weapon mastery, the limit is expert, and if you have gunslinging legend, the limit is master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificWeaponGroupCircumstanceBonus(Guid.Parse("bff19736-7f87-4527-83a3-b1a42aa11322"), WeaponGroups.Instances.Firearm.ID, bonus: 1, RollType.Attack);
            builder.GainSpecificWeaponGroupCircumstanceBonus(Guid.Parse("3c6b06cd-b968-4398-b6c4-c3750f0b4060"), WeaponGroups.Instances.Crossbow.ID, bonus: 1, RollType.Attack);

            builder
                .AddAnd(Guid.Parse("6213db0a-20a5-4751-b1ba-2d27c5d151b0"), and =>
                {
                    and.GainSingularExpertise(Guid.Parse("4bc8752e-b137-4914-863b-d354fb214693"), WeaponGroups.Instances.Firearm.ID, Proficiencies.Instances.Trained.ID);
                    and.GainSingularExpertise(Guid.Parse("6f622de8-5c01-4efd-9679-6e4937b953cd"), WeaponGroups.Instances.Crossbow.ID, Proficiencies.Instances.Trained.ID);
                })
                .AddPrerequisites(Guid.Parse("f403d81f-f353-4eb5-ad7a-783e875416e2"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("9c40d20b-8706-4561-962a-2325284bee0f"), Comparator.LessThan, requiredLevel: 5);
                });

            builder
                .AddAnd(Guid.Parse("0e31bb87-ef44-451e-9d9d-02dfa8f20edf"), and =>
                {
                    and.GainSingularExpertise(Guid.Parse("7f1cd03b-a953-495a-bf07-e137d3d4e6ba"), WeaponGroups.Instances.Firearm.ID, Proficiencies.Instances.Expert.ID);
                    and.GainSingularExpertise(Guid.Parse("14ce1621-59e2-413b-869d-b122ddc9cbcc"), WeaponGroups.Instances.Crossbow.ID, Proficiencies.Instances.Expert.ID);
                })
                .AddPrerequisites(Guid.Parse("ad5181ff-e8fb-4356-85b6-4db511a42aa5"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("add2f3d5-dff5-4a2a-b69b-9d533850045a"), Comparator.LessThan, requiredLevel: 13);
                });

            builder
              .AddAnd(Guid.Parse("3fb8580e-1b94-49cb-9b92-95c3e1067b07"), and =>
              {
                  and.GainSingularExpertise(Guid.Parse("8a164a37-1c14-47d0-b181-32ac2309fcf2"), WeaponGroups.Instances.Firearm.ID, Proficiencies.Instances.Master.ID);
                  and.GainSingularExpertise(Guid.Parse("5c0f0ef7-c162-452f-af18-e06c54e9170f"), WeaponGroups.Instances.Crossbow.ID, Proficiencies.Instances.Master.ID);
              })
              .AddPrerequisites(Guid.Parse("47ba4953-3021-4127-99db-05452341090c"), prerequisites =>
              {
                  prerequisites.HaveSpecificLevel(Guid.Parse("8267a8c9-7d16-4980-b723-994844a31255"), Comparator.GreaterThanOrEqualTo, requiredLevel: 13);
              });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("359d3a4a-1fe4-491e-9a5c-e57e888a3760"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 107
            };
        }
    }
}
