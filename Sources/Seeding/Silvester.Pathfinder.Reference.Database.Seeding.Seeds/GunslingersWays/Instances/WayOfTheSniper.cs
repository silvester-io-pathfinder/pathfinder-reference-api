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
    public class WayOfTheSniper : Template
    {
        public static readonly Guid ID = Guid.Parse("be32e74b-c6af-410b-a134-20012732c725");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Sniper",
                InitialDeedId = Feats.Instances.OneShotOneKill.ID,
                AdvancedDeedId = Feats.Instances.VitalShot.ID,
                GreaterDeedId = Feats.Instances.GhostShot.ID,
                SlingersReloadId = Feats.Instances.CoveredReload.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ed8850be-3bfe-4e28-815d-aa7f25e97f8a"), Type = TextBlockType.Text, Text = "You practice a style of shooting that relies on unerring accuracy and perfect placement of your first shot. You keep hidden or at a distance, staying out of the fray and bringing unseen death to your foes." };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("090b48d3-9e6f-4963-b41b-f4dabc936825"), Feats.Instances.OneShotOneKill.ID);
            builder.GainSpecificFeat(Guid.Parse("e638ec89-a3e6-4028-95ef-b5b119580eff"), Feats.Instances.CoveredReload.ID);
            builder.GainSpecificFeat(Guid.Parse("919ca36a-787d-40bc-a9c2-77ed36a3a479"), Feats.Instances.VitalShot.ID)
                .AddPrerequisites(Guid.Parse("32cd1874-4ed7-4779-958d-481cfb48f2e5"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("49d05951-08fb-427f-8761-40d3e66c0748"), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse("24250f20-d76b-43f6-9125-496b1da945a0"), Feats.Instances.GhostShot.ID)
                .AddPrerequisites(Guid.Parse("117868ac-b96e-47f8-9f57-3e9701049539"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("14ac783a-5b93-4de0-9937-60ae7e9fa72a"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.GainSpecificSkillProficiency(Guid.Parse("ec01e58b-2fce-41b3-a18b-08222cfaf816"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e34fa251-a892-4b1c-b162-3b170a906452"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 109
            };
        }
    }
}
