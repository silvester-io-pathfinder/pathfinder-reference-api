using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Intimidation.ID };
            yield return new GainSpecificArmorCategoryProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Trained.ID, ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID};
            yield return new GainSpecificKeyAbilityOptionEffect { Id = Guid.Parse(""), StatId = Stats.Instances.Strength.ID };
            yield return new GainSpecificArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Expert.ID,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificArmorCategoryProficiencyPrerequisite { Id = Guid.Parse(""), RequiredProficiencyId = Proficiencies.Instances.Expert.ID, ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID}
                    }
                }
            }; 
            yield return new GainSpecificArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Master.ID,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse(""),
                        Prerequisite = new HaveSpecificArmorCategoryProficiencyPrerequisite { Id = Guid.Parse(""), RequiredProficiencyId = Proficiencies.Instances.Master.ID, ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID}
                    }
                }
            };
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
