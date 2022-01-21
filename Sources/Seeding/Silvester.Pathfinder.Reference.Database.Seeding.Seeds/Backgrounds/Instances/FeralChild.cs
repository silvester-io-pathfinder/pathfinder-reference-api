using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class FeralChild : Template
    {
        public static readonly Guid ID = Guid.Parse("cd3c5cda-ccec-4789-9aec-8daf41a2ad9c");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Feral Child",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7fdea2eb-b54c-46d5-9b6e-988ce4090a4e"), Type = TextBlockType.Text, Text = "You spent your youth in the wilderness, living close to or perhaps raised by animals. You have a close, mystical connection with these animals and gained certain abilities from them, though this limited your well-roundedness in mental pursuits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("6e360c91-1bab-495b-b90c-b5f8e300f996"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("7659e42c-eec3-42b0-88c6-b6f314346b03"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("50e3592e-0696-42d5-a04f-5734198ec4d8"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("cd846ad5-1934-4007-8fb8-04239a968ac4"), Stats.Instances.Constitution.ID);
            });

            builder.AddAnd(Guid.Parse("a9ffbd33-e6d9-4caa-a66b-db8b586c2a67"), and => 
            {
                and.GainSpecificSkillProficiency(Guid.Parse("b36501a3-f75d-479d-93f8-bc3e8d9f249e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                and.GainSpecificSkillProficiency(Guid.Parse("479c154a-c893-461d-88b3-674b20c7370a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            });

            builder.AddOr(Guid.Parse("72161188-109e-41a3-95ef-7d920ff2d156"), or =>
            {
                or.GainSpecificSense(Guid.Parse("f9fd5fa5-6421-4eb0-b8d5-762a6ff0d10f"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                or.GainSpecificSense(Guid.Parse("23c3aaa8-de49-4cce-8461-e400cfe43857"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("ea5c28bc-5894-4fad-b975-e8bb97fea3dd"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("4503ee62-123c-40ce-9a65-b54bd21c0820"), Senses.Instances.LowLightVision.ID);
                    });
            });

            builder.GainSpecificSense(Guid.Parse("f5eae4dc-e515-4ada-bb0b-11b3dd5f3e24"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificFeat(Guid.Parse("d5ef1fe3-db71-404e-8728-26127524faa7"), Feats.Instances.Forager.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e51527d-46ec-4395-99c5-6114da611650"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 50
            };
        }
    }
}
