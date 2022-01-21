using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays.Instances
{
    public class WayOfTheVanguard : Template
    {
        public static readonly Guid ID = Guid.Parse("6405b0e7-c756-47c1-9db3-c5347ac907c4");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Vanguard",
                InitialDeedId = Feats.Instances.LivingFortification.ID,
                AdvancedDeedId = Feats.Instances.SpinningCrush.ID,
                GreaterDeedId = Feats.Instances.Siegebreaker.ID,
                SlingersReloadId = Feats.Instances.ClearAPath.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("930695e3-25f6-49b5-943f-8483461406a4"), Type = TextBlockType.Text, Text = "You practice a unique combat style originated by dwarven siege engineers, using heavy weapons with wide attack areas to blast holes through enemy lines, clear an opening for your allies, and defend the conquered territory." };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("10583e1c-b3b6-4861-b67c-5c2dae28ff87"), Feats.Instances.LivingFortification.ID);
            builder.GainSpecificFeat(Guid.Parse("2ec4c2c1-3b47-4aae-8a40-47603a34e8bd"), Feats.Instances.ClearAPath.ID);
            builder.GainSpecificFeat(Guid.Parse("7b25a31a-8dcc-47ee-be39-442e39a9f5bb"), Feats.Instances.SpinningCrush.ID)
                .AddPrerequisites(Guid.Parse("7d61acaa-a789-46b1-9146-1edd45ef3070"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("98cecfb2-d44b-468e-a0d6-2909a8959a3b"), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse("0eac4b90-df78-42ad-97bf-c1936fc37b0f"), Feats.Instances.Siegebreaker.ID)
                .AddPrerequisites(Guid.Parse("98c01a09-59a1-42d9-87a9-9b9049eeb05d"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("8704cf82-66db-43fb-909b-4994652b5a85"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.GainSpecificSkillProficiency(Guid.Parse("807e232d-8ebd-4218-a6ed-51fba0bf0fa6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("124caced-2931-4820-9fc8-5d350aac3aaf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 110
            };
        }
    }
}
