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
        public static readonly Guid ID = Guid.Parse("b6a33ffd-d24f-4173-a15e-239280a4da60");
        
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
            yield return new TextBlock { Id = Guid.Parse("cd679934-91f4-44ee-934d-fa9cf58ada67"), Type = TextBlockType.Text, Text = "You prefer to strong-arm or intimidate others rather than rely on finesse or fancy tricks. You might be an enforcer for organized crime, a highway bandit, or a noble who bullies others with threats of your family's power. Or, you might use your skills on the up and up, in a private security detail or as a guard in a city with the right temperament." };
            yield return new TextBlock { Id = Guid.Parse("7522bfd6-9525-4da9-babc-4fa3aa47f62a"), Type = TextBlockType.Text, Text = "You use whatever tools you have at hand to get the job done. You can deal sneak attack damage with any simple weapon, in addition to the weapons listed in the sneak attack class feature. When you critically succeed at an attack roll using a simple weapon and the target has the flat-footed condition (unable to focus on defending itself), you also apply the critical specialization effect for the weapon you're wielding. You don't gain these benefits if the weapon has a damage die larger than d8 (after applying any abilities that alter its damage die size)." };
            yield return new TextBlock { Id = Guid.Parse("2e431b59-98c1-47af-8b8e-397e62e2c716"), Type = TextBlockType.Text, Text = "You're trained in Intimidation and medium armor. You can choose Strength as your key ability score. When you gain light armor expertise, you also gain expert proficiency in medium armor, and when you gain light armor mastery, you also gain master proficiency in medium armor." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("81827c4d-1d59-4b26-9756-95f0c1e69807"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("2877a092-f761-45f5-99b7-b65afdc403f7"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
            builder.GainSpecificKeyAbilityOption(Guid.Parse("113a93dc-2564-45d0-bad8-9d3038bc4c2d"), Stats.Instances.Strength.ID);

            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("818fcd08-83b5-4e7d-8eb3-189c77be8f39"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID)
                .AddPrerequisites(Guid.Parse("14071641-2ff6-4713-b9e5-a851a7842fc9"), prerequisites =>
                {
                    prerequisites.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("c4f1bd9f-603c-4cc8-b767-a917f1189b63"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
                });
           
            builder.GainSpecificArmorCategoryProficiency(Guid.Parse("58420b55-7795-4d10-958c-0d220d0e64ee"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.MediumArmor.ID)
                            .AddPrerequisites(Guid.Parse("e065b17f-d2d1-4d32-998b-f5fd60ade816"), prerequisites =>
                            {
                                prerequisites.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("3076c2ab-58cb-41da-93d0-c07458990697"), Proficiencies.Instances.Master.ID, ArmorCategories.Instances.LightArmor.ID);
                            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d2d8d97-8f96-4393-bfe1-482e150dd579"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 180
            };
        }
    }
}
