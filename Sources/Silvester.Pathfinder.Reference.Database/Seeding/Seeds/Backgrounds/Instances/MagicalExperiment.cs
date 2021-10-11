using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MagicalExperiment : Template
    {
        public static readonly Guid ID = Guid.Parse("fa4b262d-3ed5-485d-b314-af3701f92307");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Magical Experiment",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("84dca2fe-488e-45a6-89cb-e5bc211b7df5"), Type = TextBlockType.Text, Text = "At some point in your life, powerful people performed magical experiments on you that changed you permanently. You may have signed up for this voluntarily, but it may have been against your will. You still bear the marks, as well as the abilities." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Aasimar.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("7dc06df4-e53b-4f7e-8cd8-5072493354fa"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("653750e2-b1cc-48f3-b46a-cf6384a69a71"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("443234c6-b18e-4daa-ad55-326a87a7de46"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("2387b662-c8e2-4d50-bf58-b2d28988d4f3"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Academia.ID
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("7531962a-ecbd-4b96-97b9-8e422d315d05"),
                Restrictions = "You gain one special ability as a result of the magical experimentation. Work with the GM to select an appropriate ability from the following list or to come up with another special ability.",
                Choices = new Effect[]
                {
                    //Enhanced Senses
                    new CombinedEffect
                    {
                        Id = Guid.Parse("4049ce2d-4eee-4a4b-953b-308b41f46a3f"),
                        Entries = new Effect[] 
                        {
                            new ChoiceEffect
                            {
                                Id = Guid.Parse("467ea219-09c1-4584-95cc-6e1077e7073e"),
                                Restrictions = "The darkvision effect can only be chosen if you already have low-light vision.",
                                Choices = new Effect[]
                                {
                                    new SenseEffect { Id = Guid.Parse("2cdbc71d-2830-4693-8cf7-46c2e8d5335b"), SenseId = Senses.Instances.LowLightVision.ID, },
                                    new SenseEffect { Id = Guid.Parse("5f52e7e7-e947-4315-a07f-ed5409d01863"), SenseId = Senses.Instances.Darkvision.ID}
                                }
                            },
                            new FreeSenseEffect { Id = Guid.Parse("5ddcf11b-c2e0-4d76-a715-337ada98f40d"), Range = "30 feet." }
                        }
                    },

                    //Resistant Skin
                    new CombinedEffect
                    {
                        Id = Guid.Parse("0b2c1ecf-cc39-479e-867a-0a7eb3c67407"),
                        Entries = new Effect[]
                        {
                            new ChoiceEffect
                            {
                                Id = Guid.Parse("c98881d6-e7d2-45e6-8850-7b75c6611024"),
                                Choices = new Effect[]
                                {
                                    new DamageResistanceEffect {Id = Guid.Parse("bba7f018-45d4-497a-b169-c2f572ba09b8"), DamageTypeId = DamageTypes.Instances.Acid.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("13883b39-6a68-4b8c-b0c0-8a2cd652a8d6"), DamageTypeId = DamageTypes.Instances.Cold.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("1fc38d95-4715-42a7-af28-1c8083af090b"), DamageTypeId = DamageTypes.Instances.Electricity.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("02d61601-6ffc-4f6f-bc39-232910bf21fb"), DamageTypeId = DamageTypes.Instances.Fire.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("b7feaa22-0d67-429d-a375-28a3516730ff"), DamageTypeId = DamageTypes.Instances.Sonic.ID},
                                }
                            },
                            new ChoiceEffect
                            {
                                Id = Guid.Parse("94e76d79-473d-4cfa-87cd-6cb5ef315514"),
                                Restrictions = "Is chosen by the GM, and should differ from the resistance type chosen by the player.",
                                Choices = new Effect[]
                                {
                                    new DamageResistanceEffect {Id = Guid.Parse("4b5b9f9d-f0de-4429-82bb-ecd2d084707d"), DamageTypeId = DamageTypes.Instances.Acid.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("9d807728-796b-4700-a926-991613e16616"), DamageTypeId = DamageTypes.Instances.Cold.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("46d5ce22-2726-40fd-99e1-b9d2051ddd0a"), DamageTypeId = DamageTypes.Instances.Electricity.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("3480ce6f-a368-4d1c-b64a-2d4cdd5e02e2"), DamageTypeId = DamageTypes.Instances.Fire.ID},
                                    new DamageResistanceEffect {Id = Guid.Parse("12c56afd-f949-4c80-84dd-9a7146e608a8"), DamageTypeId = DamageTypes.Instances.Sonic.ID},
                                }
                            }
                        }
                    },

                    //Touch Telepathy
                    new AbilityEffect
                    {
                        Id = Guid.Parse("86be3232-1360-4a64-8db2-0a7c133f9814"),
                        AbilityId = Abilities.Instances.Telepathy.ID,
                        Range = "Touch."
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6504d33-1fa9-446b-a8d0-9e3e52cd6160"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
