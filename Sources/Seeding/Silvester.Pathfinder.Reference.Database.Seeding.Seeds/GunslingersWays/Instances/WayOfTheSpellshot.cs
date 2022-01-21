using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.GunslingersWays.Instances
{
    public class WayOfTheSpellshot : Template
    {
        public static readonly Guid ID = Guid.Parse("619b29f2-595b-4ac8-bf2a-5b48c2b6b8eb");
        
        protected override GunslingersWay GetGunslingersWay()
        {
            return new GunslingersWay
            {
                Id = ID, 
                Name = "Way of the Spellshot",
                InitialDeedId = Feats.Instances.EnergyShot.ID,
                AdvancedDeedId = Feats.Instances.RecallAmmunition.ID,
                GreaterDeedId = Feats.Instances.DispellingBullet.ID,
                SlingersReloadId = Feats.Instances.ThoughtfulReload.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("898f258f-7cfc-49e1-b07d-8ab23dae390a"), Type = TextBlockType.Text, Text = "You've learned the intricacies of magic and technology, blending the two together with deadly results. You combine a knowledge of arcane theories with a strong connection to your chosen weapon that allows you to manifest unique effects, though your knowledge doesn't extend as far as actual spellcasting. You can imbue energy into your weapon and conjure bullets from thin air. As you progress, you eventually learn to phase bullets through walls or even to teleport yourself along the path of your bullets." };
            yield return new TextBlock { Id = Guid.Parse("c6788729-0024-4fef-93e8-04b8b8c446a0"), Type = TextBlockType.Text, Text = "You must select Spellshot Dedication from the Spellshot archetype as your 2nd-level class feat." };

            //TODO: Encapsulate the forced 2nd-level class feat pick somehow.
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        {
            builder.HaveSpecificClass(Guid.Parse("e5b2903b-7722-4a63-836a-5f4f68fe7a8e"), Classes.Instances.Gunslinger.ID);
        }

        protected override IEnumerable<Guid> GetWaySkills()
        {
            yield return Skills.Instances.Arcana.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("44bb9878-d6c0-4d9b-b379-d4154b88209a"), Feats.Instances.ThoughtfulReload.ID);
            builder.GainSpecificFeat(Guid.Parse("4a8fe1d9-689b-4501-a3bf-d1156c3283fa"), Feats.Instances.EnergyShot.ID);
            builder.GainSpecificFeat(Guid.Parse("403dfb2c-c4a4-46c0-8e8b-41d86c5f89bb"), Feats.Instances.RecallAmmunition.ID)
                .AddPrerequisites(Guid.Parse("d9ef3d72-0f73-44dc-af3f-fa2ad1f03e00"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("01ce8890-53be-4051-9642-d1d442b0087a"), Comparator.GreaterThanOrEqualTo, requiredLevel: 9);
                });

            builder.GainSpecificFeat(Guid.Parse("3afe4dc4-763e-461e-9dbd-c6d254d4f372"), Feats.Instances.DispellingBullet.ID)
                .AddPrerequisites(Guid.Parse("be895685-12c8-41c3-90cf-3f30b6d19fdb"), prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(Guid.Parse("64a1bffa-6fbd-4c6d-9b09-437414e546c0"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15);
                });

            builder.GainSpecificSkillProficiency(Guid.Parse("6d102567-c604-4afe-896b-f1831660be85"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("119417b0-474d-4bb1-8c2b-9b0926dba0d8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 140
            };
        }
    }
}
