using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class LaborerAndroid : Template
    {
        public static readonly Guid ID = Guid.Parse("a69c2537-ca7d-4311-97c8-67ab96a54217");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Laborer Android"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fa6b832c-9a74-4e1c-a195-65e5d0c7782d"), Type = TextBlockType.Text, Text = "Your body is adapted to endure physical hardships or perform hard labor for long periods of time. You become trained in Athletics (or another skill if you're already trained in Athletics), and you gain the Hefty Hauler skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("2a510a14-0e4b-4508-80a1-8dbcb3ec0563"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("c58a0ad9-e003-4aca-986b-bf70ad7c228b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
                or.GainAnySkillProficiency(Guid.Parse("326fb773-e05e-4f07-8800-96c1aaabd16c"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("159083d7-b2b8-41e2-bda7-ab53a1522bc7"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("a274e9f1-ea32-4e34-ada2-f05d16734f62"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
                    });
            });
            builder.GainSpecificFeat(Guid.Parse("31357802-a3a8-4725-bcb7-8ae1842e29a7"), Feats.Instances.HeftyHauler.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c62e2cf4-29bf-4c14-a948-8ab110c6eec7"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Android.ID;
        }
    }
}
