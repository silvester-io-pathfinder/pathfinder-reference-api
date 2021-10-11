using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class HarrowLed : Template
    {
        public static readonly Guid ID = Guid.Parse("3719c441-3a06-40a1-bdaf-ac7afaf0d8b5");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Harrow-Led",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7629d11b-fcf3-4c37-8496-3717fdc8071d"), Type = TextBlockType.Text, Text = "You were the subject of a harrow reading at a pivotal point in your life, such as on an important birthday, or upon reaching adulthood. The reading was eerily accurate and has been relevant, for good or ill, at more points in your life than you could call mere coincidence." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Aasimar.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new HarrowEffect
            {
                Id = Guid.Parse("15cfd57b-e027-456c-9a4f-3bf7d905aa80"),
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("8b273ad8-f564-4048-9811-daba227c566a")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("1c2a23a6-a2ee-4d83-a75a-b2f61a1b8a62"),
                Choices = new Effect[]
                {
                    new RestrictedSkillEffect { Id = Guid.Parse("e2cd6901-17f7-4f6d-b960-9e090f43c865"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID },
                    new RestrictedSkillEffect { Id = Guid.Parse("92944cf8-0a7d-4f3c-be0d-5b38ea0ac8d5"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Performance.ID },
                    new RestrictedSkillEffect { Id = Guid.Parse("c45efea0-28c2-4943-9b87-273d7b8b62f2"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Society.ID }
                }
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("63618d77-da6a-46b1-9d4d-697cec31ec23"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Harrow.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("46cdb645-5894-4f66-bd3b-9f976b496696"),
                FeatId = Feats.General.DubiousKnowledgeFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ffdb8cb-cb40-4e7c-b3a3-e19d4b51d7d7"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
