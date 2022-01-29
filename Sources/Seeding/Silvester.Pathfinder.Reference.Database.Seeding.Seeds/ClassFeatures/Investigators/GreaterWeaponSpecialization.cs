using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class GreaterWeaponSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("6639246d-2eba-4698-b8d1-297031794bc7");

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
            yield return new TextBlock { Id = Guid.Parse("aed6f647-e2ea-41c4-88a4-8dae1ae5bb01"), Type = TextBlockType.Text, Text = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you're an expert, 6 if you're a master, and 8 if you're legendary." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyWeaponDamage(Guid.Parse("6fed0410-4cad-4fbd-8cd0-449d2165ecdb"), ModifierType.Add, modifier: 2)
                .AddPrerequisites(Guid.Parse("99676f63-d25a-405e-beae-1632e9a4c484"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("0c7420fc-9e81-41e1-bfe8-ac341faf77e0"), Comparator.EqualTo, Proficiencies.Instances.Expert.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("771945de-f138-4431-b69d-afacfd192b60"), ModifierType.Add, modifier: 3)
                .AddPrerequisites(Guid.Parse("3a278e39-3289-4755-a6f1-1430f339f61e"), prerequisites =>
                {
                    prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("1fe066f8-aa2f-467e-ab15-6ecb0a16007e"), Comparator.EqualTo, Proficiencies.Instances.Master.ID);
                });

            builder.ModifyWeaponDamage(Guid.Parse("b148307e-1e5f-4961-a002-362ab1722823"), ModifierType.Add, modifier: 4)
               .AddPrerequisites(Guid.Parse("ecb46365-c289-4e79-a7e5-b8c2946a9eb2"), prerequisites =>
               {
                   prerequisites.HaveCurrentWeaponProficiency(Guid.Parse("844adfc7-167e-46bc-aa07-ae96cc1e9c65"), Comparator.EqualTo, Proficiencies.Instances.Legendary.ID);
               });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("deb6ee7a-0a0b-4684-bf31-686f84130fad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 59
            };
        }
    }
}
