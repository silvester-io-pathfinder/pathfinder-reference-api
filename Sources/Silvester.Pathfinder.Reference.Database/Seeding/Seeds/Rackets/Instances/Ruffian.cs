using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets.Instances
{
    public class Ruffian : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Racket GetRacket()
        {
            return new Racket
            {
                Id = ID, 
                Name = "Ruffian",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You prefer to strong-arm or intimidate others rather than rely on finesse or fancy tricks. You might be an enforcer for organized crime, a highway bandit, or a noble who bullies others with threats of your family's power. Or, you might use your skills on the up and up, in a private security detail or as a guard in a city with the right temperament." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You use whatever tools you have at hand to get the job done. You can deal sneak attack damage with any simple weapon, in addition to the weapons listed in the sneak attack class feature. When you critically succeed at an attack roll using a simple weapon and the target has the flat-footed condition (unable to focus on defending itself), you also apply the critical specialization effect for the weapon you're wielding. You don't gain these benefits if the weapon has a damage die larger than d8 (after applying any abilities that alter its damage die size)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're trained in Intimidation and medium armor. You can choose Strength as your key ability score. When you gain light armor expertise, you also gain expert proficiency in medium armor, and when you gain light armor mastery, you also gain master proficiency in medium armor." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse(""), Stats.Instances.Strength.ID);

            builder.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID)
                .AddPrerequisites(Guid.Parse(""), prerequisites =>
                {
                    prerequisites.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
                });
           
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.MediumArmor.ID)
                            .AddPrerequisites(Guid.Parse(""), prerequisites =>
                            {
                                prerequisites.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
                            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 180
            };
        }
    }
}
