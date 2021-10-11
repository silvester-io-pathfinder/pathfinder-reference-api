using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Scholar : Template
    {
        public static readonly Guid ID = Guid.Parse("fb442e73-4d3c-4e7a-87e2-c135da6c5024");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Scholar",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5445779f-6c29-458a-9bce-2582ca7e87e2"), Type = TextBlockType.Text, Text = "You have a knack for learning, and sequestered yourself from the outside world to learn all you could. You read about so many wondrous places and things in your books, and always dreamed about one day seeing the real things. Eventually, that curiosity led you to leave your studies and become an adventurer." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("13fa87ba-1ce3-483b-a738-97af17057cbb"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("fce39680-c6c8-4bd0-bc26-694722fa7853"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("50be44a1-1fbb-44ff-a543-2fafed0f17fc"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("25f07743-2d4a-450b-a0db-54285531f6d9")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("fb8ffa2d-5602-406e-a95f-543b8b9097ed"),
                Choices = new Effect[]
                {
                    new CombinedEffect
                    {
                        Id = Guid.Parse("b1067069-0950-4e07-9736-bee597249980"),
                        Entries = new Effect[] {
                            new RestrictedSkillEffect { Id = Guid.Parse("8cc75237-bb1d-4c94-9734-1f8d10e97d92"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Arcana.ID },
                            new FeatEffect { Id = Guid.Parse("faa677bf-583c-4edb-a040-c0a8d4dd7997"), FeatId = Feats.General.AssuranceFeat.ID, Restrictions = "The assurance skill feat should relate to the Arcana skill." }
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("67d0ae8f-05fd-407f-92ea-00712b975e37"),
                        Entries = new Effect[] {
                            new RestrictedSkillEffect { Id = Guid.Parse("ba5a4b8f-48b2-4561-9872-cffa1ba9a19a"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Nature.ID },
                            new FeatEffect { Id = Guid.Parse("49e49212-8901-45a2-acd9-6edcb6f4044a"), FeatId = Feats.General.AssuranceFeat.ID, Restrictions = "The assurance skill feat should relate to the Nature skill." }
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("80ac3a10-4475-4044-85e4-5e02155155fc"),
                        Entries = new Effect[] {
                            new RestrictedSkillEffect { Id = Guid.Parse("f1a287b0-3c9d-4271-ad53-1228b8a52624"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID },
                            new FeatEffect { Id = Guid.Parse("1cf20334-1d7c-4609-b453-387ab11ea814"), FeatId = Feats.General.AssuranceFeat.ID, Restrictions = "The assurance skill feat should relate to the Occultism skill." }
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("d548fa59-3625-488d-89e7-0130cd2e2160"),
                        Entries = new Effect[] {
                            new RestrictedSkillEffect { Id = Guid.Parse("4db4bafb-1adc-43eb-9ec5-e532e2f42baa"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Religion.ID },
                            new FeatEffect { Id = Guid.Parse("c5200f87-a16f-4bad-a017-ddd60053997a"), FeatId = Feats.General.AssuranceFeat.ID, Restrictions = "The assurance skill feat should relate to the Religion skill." }
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c5f506a-2d83-43fd-952d-fae77f034915"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
