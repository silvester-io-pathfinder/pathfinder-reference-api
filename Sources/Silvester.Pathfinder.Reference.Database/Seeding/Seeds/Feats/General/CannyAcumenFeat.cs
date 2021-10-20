using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class CannyAcumenFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("85740fcc-7aaf-494f-81d7-8360620977d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Canny Acumen",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f69671b-1e75-49a2-b6a8-d418bbf60f3f"), Type = Utilities.Text.TextBlockType.Text, Text = "Your avoidance or observation is beyond the ken of most in your profession. Choose Fortitude saves, Reflex saves, Will saves, or Perception. You become an expert in your choice. At 17th level, you become a master in your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override IEnumerable<Effect> GetCharacterEffects()
        {
            yield return new ChoiceEffect
            {
                Id = Guid.Parse("090d45ed-e6da-46af-9f9a-373b44365539"),
                Entries = new Effect[]
                {
                    new GainSpecificSavingThrowProficiencyEffect
                    {
                        Id = Guid.Parse("f5663e90-eacd-4ce5-8c1f-572d4cccb072"),
                        ProficiencyId = Proficiencies.Instances.Expert.ID,
                        SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                        Increments = new EffectIncrement[]
                        {
                            new IncreaseProficiencyToIncrement
                            {
                                Id = Guid.Parse("13d37daf-671d-4183-876e-688b969daa03"),
                                ProficiencyId = Proficiencies.Instances.Master.ID,
                                Trigger = new LevelTrigger { Id = Guid.Parse("add0fccb-558a-40b9-9c49-2bd20291ad30"), Level = 17 }
                            }
                        }
                    },

                    new GainSpecificSavingThrowProficiencyEffect
                    {
                        Id = Guid.Parse("157f2b08-4137-4d77-82e5-086bc5ccf646"),
                        ProficiencyId = Proficiencies.Instances.Expert.ID,
                        SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                        Increments = new EffectIncrement[]
                        {
                            new IncreaseProficiencyToIncrement
                            {
                                Id = Guid.Parse("78b9458b-87f1-44ae-aa27-b77f68e36d03"),
                                ProficiencyId = Proficiencies.Instances.Master.ID,
                                Trigger = new LevelTrigger { Id = Guid.Parse("02498166-ccdc-4117-8007-1c11215855d9"), Level = 17 }
                            }
                        }
                    },

                    new GainSpecificSavingThrowProficiencyEffect
                    {
                        Id = Guid.Parse("5e459097-cc7c-4107-8924-0367f5f9b631"),
                        ProficiencyId = Proficiencies.Instances.Expert.ID,
                        SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                        Increments = new EffectIncrement[]
                        {
                            new IncreaseProficiencyToIncrement
                            {
                                Id = Guid.Parse("fcf6bc7b-583b-450d-bc25-3e8bdcc7a38e"),
                                ProficiencyId = Proficiencies.Instances.Master.ID,
                                Trigger = new LevelTrigger { Id = Guid.Parse("a8fba440-e3f4-47b1-98f0-320e9d13b75d"), Level = 17 }
                            }
                        }
                    },

                    new GainSpecificSkillProficiencyEffect
                    {
                        Id = Guid.Parse("bdc2f2ab-304c-4ede-af1a-d9e5bcaca3a6"),
                        ProficiencyId = Proficiencies.Instances.Expert.ID,
                        SkillId = Skills.Instances.Perception.ID,
                        Increments = new EffectIncrement[]
                        {
                            new IncreaseProficiencyToIncrement
                            {
                                Id = Guid.Parse("1150371f-439d-40e2-bc03-082d67891033"),
                                ProficiencyId = Proficiencies.Instances.Master.ID,
                                Trigger = new LevelTrigger { Id = Guid.Parse("aabe8312-3da2-4e19-8cff-cdb74d7819c8"), Level = 17 }
                            }
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f24fb127-2f4f-4ded-b0ec-e5f366a7b7d2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 259
            };
        }
    }
}
