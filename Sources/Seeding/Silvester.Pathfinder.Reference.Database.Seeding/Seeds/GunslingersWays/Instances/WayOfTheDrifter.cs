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
    public class WayOfTheDrifter : Template
    {
        public static readonly Guid ID = Guid.Parse("09ef1ef0-c8ba-45d0-9b36-6803827648f6");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Drifter",
                InitialDeedId = Feats.Instances.IntoTheFray.ID,
                AdvancedDeedId = Feats.Instances.FinishTheJob.ID,
                GreaterDeedId = Feats.Instances.DriftersWake.ID,
                SlingersReloadId = Feats.Instances.ReloadingStrike.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0577eb09-91f5-48b9-8971-92ab4c1f254d"), Type = TextBlockType.Text, Text = "You're a wanderer traveling from land to land with your gun and a melee weapon as company. Maybe you learned to fight with blade and pistol as a Shackles pirate, mastered the hand cannon and katana in Minkai, or practiced with a hatchet and clan pistol in Dongun Hold. You win battles by relying on mobility and flexible use of your weapons." };
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("2caf39d6-2268-4add-9206-56176001894d"), Feats.Instances.ReloadingStrike.ID);
            builder.GainSpecificFeat(Guid.Parse("024e8593-0da9-49f9-8d34-1b674be10596"), Feats.Instances.IntoTheFray.ID);
            builder.GainSpecificFeat(Guid.Parse("b47aac04-b0d3-46f3-962a-a32307d08d96"), Feats.Instances.FinishTheJob.ID)
                .AddPrerequisites(Guid.Parse("4ea0bd7f-9bce-4fdd-b21d-32d541fb0ca1"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("cbaf71e5-8df5-42c4-860b-774f1911da29"), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse("51553c7a-04b4-4b35-967d-01b6e9d23485"), Feats.Instances.DriftersWake.ID)
                .AddPrerequisites(Guid.Parse("8520962d-145a-4ab9-9c15-09c587772068"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("75d48cd5-2923-450f-a619-0170f9f2fd8c"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.GainSpecificSkillProficiency(Guid.Parse("e0772f6e-3a72-40b2-8995-c129439d6e39"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47f1dd86-83c4-4b6a-be6e-08183ee4397b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 108
            };
        }
    }
}
