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
            builder.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.Addendum("You gain one special ability as a result of the magical experimentation. Work with the GM to select an appropriate ability from the following list or to come up with another special ability.");
                
                //Enhanced Senses
                or.AddAnd(Guid.Parse(""), and => 
                {
                    and.GainAnySense(Guid.Parse(""), "30 feet.");
                    and.AddOr(Guid.Parse(""), or => 
                    {
                        or.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID);
                        or.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID)
                            .AddPrerequisites(Guid.Parse(""), prerequisites => 
                            {
                                prerequisites.HaveSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID);
                            });
                    });
                });

                //Resistant Skin
                or.AddAnd(Guid.Parse(""), and => 
                {
                    and.AddOr(Guid.Parse(""), or => 
                    {
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Acid.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Cold.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Electricity.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Fire.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Sonic.ID);
                    });

                    and.AddOr(Guid.Parse(""), or =>
                    {
                        or.Addendum("Is chosen by the GM, and should differ from the resistance type chosen by the player.");
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Acid.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Cold.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Electricity.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Fire.ID);
                        or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Sonic.ID);
                    });
                });

                //Touch Telepathy
                builder.GainSpecificAbility(Guid.Parse(""), Abilities.Instances.Telepathy.ID, "Touch.");
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
