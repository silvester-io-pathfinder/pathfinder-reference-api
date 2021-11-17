using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificAbilityBoost(Guid.Parse("2abcac8e-37eb-44bd-a378-ce4a070068c7"), Stats.Instances.Constitution.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("065fcb88-408d-40c4-ba1d-3324379a06b1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("9252efd0-d14c-497b-aa0a-b044075118e7"), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            
            builder.AddOr(Guid.Parse("be63477b-e2b3-44b2-a7a4-22a290693249"), or => 
            {
                or.Addendum("You gain one special ability as a result of the magical experimentation. Work with the GM to select an appropriate ability from the following list or to come up with another special ability.");
                
                //Enhanced Senses
                or.AddAnd(Guid.Parse("0c4b1a0a-9dcd-40c2-879d-fad319c300f3"), and => 
                {
                    and.GainAnySense(Guid.Parse("9e4f686a-42ad-4d5b-920e-d5c982ef3572"), SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
                    and.AddOr(Guid.Parse("8c5ed16d-d2c1-48f8-9f62-7c30e3101876"), or => 
                    {
                        or.GainSpecificSense(Guid.Parse("45dab562-f548-4ab6-b206-eb64bc46624f"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                        or.GainSpecificSense(Guid.Parse("be9d7251-939a-450a-8e9c-3a7cad689eb8"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                            .AddPrerequisites(Guid.Parse("60987a03-18c7-40ca-8d84-8864501cf932"), prerequisites => 
                            {
                                prerequisites.HaveSpecificSense(Guid.Parse("e6f50d8a-5b50-444a-92c2-dc79888513a3"), Senses.Instances.LowLightVision.ID);
                            });
                    });
                });

                //Resistant Skin
                or.AddAnd(Guid.Parse("d44010bb-d7fd-4c8b-badc-0f30b219d4f0"), and => 
                {
                    and.AddOr(Guid.Parse("0cb830c8-3ee6-4f57-885a-7a1d94f2d03e"), or => 
                    {
                        or.GainSpecificDamageResistance(Guid.Parse("786774c1-2155-4c22-b063-f08a600d968f"), DamageTypes.Instances.Acid.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("2303f498-d363-4439-a081-dea7f92ed50c"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("6d8d9baa-3e57-4461-90eb-ac8547c6be6c"), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("566ddf52-63db-42f0-b5df-c6cb76da204a"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("d0398c79-d0db-48fd-b48f-0f6d53c7f685"), DamageTypes.Instances.Sonic.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                    });

                    and.AddOr(Guid.Parse("ad67ba9b-4cc5-491d-ae09-8ceb3a0fb249"), or =>
                    {
                        or.Addendum("Is chosen by the GM, and should differ from the resistance type chosen by the player.");
                        or.GainSpecificDamageResistance(Guid.Parse("b877c9f7-64f0-4f1e-ae37-b0d1d03d1002"), DamageTypes.Instances.Acid.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("735c1bf8-67d2-47e3-aa61-5f0811409309"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("3ad2997f-cd86-4449-b05d-e5143f97b857"), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("ebe61dc7-1f24-4ed2-85ce-a042acaf1d0d"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                        or.GainSpecificDamageResistance(Guid.Parse("936ca2b2-042d-42a7-8e6e-125f6c76581b"), DamageTypes.Instances.Sonic.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                    });
                });

                //Touch Telepathy
                builder.GainSpecificAbility(Guid.Parse("d12d72d2-ac2a-43ce-a44a-7578bcda899f"), Abilities.Instances.Telepathy.ID, "Touch.");
            });
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
