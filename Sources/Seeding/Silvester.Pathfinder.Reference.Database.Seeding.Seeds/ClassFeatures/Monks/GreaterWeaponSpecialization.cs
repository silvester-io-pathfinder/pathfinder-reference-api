using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("3f8bfbd4-9232-4e92-92ce-475d7ea388ac");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Greater Weapon Specialization", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f6ed7b4e-4bb0-4c79-b7c1-de74949dc761"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you're an expert, 6 if you're a master, and 8 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("3a37dc36-2e69-4b6c-9430-328cd8c18811"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("3a29c048-d4ad-4e80-8716-e60da58aee70"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("34acf059-6c93-462b-9dec-b261a21e5788"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("0be9f38a-b11e-4bfb-bfe6-7762726566aa"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("e38ac792-9db2-406c-9a5a-ae05462a3eb7"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("9ecc2574-67f3-48bc-b4dc-08d1fbaa2f10"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("0ddea035-b34e-4542-a9d3-3fd196f937ad"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("19b95ef3-4cb7-43c3-8d8a-675fff737f1e"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("9df230af-18ef-4ba5-a60d-efcfd9d18758"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec172ec6-cbc8-4add-9730-1da792293143"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
