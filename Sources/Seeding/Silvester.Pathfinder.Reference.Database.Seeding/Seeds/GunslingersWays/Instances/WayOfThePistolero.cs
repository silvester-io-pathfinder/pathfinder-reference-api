using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays.Instances
{
    public class WayOfThePistolero : Template
    {
        public static readonly Guid ID = Guid.Parse("339ff621-6592-4459-89a3-71f349d2eb6c");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Pistolero",
                InitialDeedId = Feats.Instances.TenPaces.ID,
                AdvancedDeedId = Feats.Instances.PistolersRetort.ID,
                GreaterDeedId = Feats.Instances.GrimSwagger.ID,
                SlingersReloadId = Feats.Instances.RaconteursReload.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d7836e5b-9376-40ec-a28a-7daee054f43a"), Type = TextBlockType.Text, Text = "Whether you're a professional duelist or a pistol-twirling entertainer, you have quick feet and quicker hands that never seem to let you down, and an equally sharp wit and tongue that jab your foes. You might leave a hand free or cultivate the ambidexterity for twin weapons. Either way, you stay close enough to your enemies to leverage your superior reflexes while leaving enough space to safely fire." };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Deception.ID;
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("6c581221-09c7-4bb5-9158-28d17fa60a28"), Feats.Instances.RaconteursReload.ID);
            builder.GainSpecificFeat(Guid.Parse("07dbdebc-51ea-4ad3-a7e0-14220798e581"), Feats.Instances.TenPaces.ID);
            builder.GainSpecificFeat(Guid.Parse("63266a01-6091-4ab7-98a8-6c4e8317e341"), Feats.Instances.PistolersRetort.ID)
                .AddPrerequisites(Guid.Parse("2ef1f317-3de8-4717-9a53-384183f23574"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("e70dc630-e5e7-419f-8afa-a0bd33d39dc4"), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse("e5d6d24c-0af6-456e-8c9c-d787e79c29af"), Feats.Instances.GrimSwagger.ID)
                .AddPrerequisites(Guid.Parse("03a1a7c4-eb32-4aef-b9c0-8d334ba95d8d"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("f70f11ce-1678-4870-96ef-6366a0879c95"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.AddOr(Guid.Parse("6971a5bb-0180-46e0-b459-28ad4d83da71"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("438b49e8-c0ad-4d65-b577-01b1b9b8d07a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("8bcad71e-1484-4f26-8d37-3ec9c19d9836"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c58c0625-ac8c-40d8-921a-2e5afacb455f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 109
            };
        }
    }
}
