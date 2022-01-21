using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders.Instances
{
    public class Flame : Template
    {
        public static readonly Guid ID = Guid.Parse("c1e91c35-890f-46a7-8d67-d171eb4c2580");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Flame",
                Description = "You feel a kinship with flames and can use them for succor and destruction. You're trained in Acrobatics. You also gain the Fire Lung druid feat. You gain the wildfire order spell. Allowing unnatural fires to spread or preventing natural fires from occurring in a way that harms the environment are anathema to your order (this doesn't prevent you from using fire destructively or force you to combat a controlled or natural fire).",
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("978b5142-85d1-4de2-bc6a-9bcc0e759896"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.GainSpecificFeat(Guid.Parse("835b3c6b-28b4-463b-9a27-9ab0676a32df"), Feats.Instances.FireLung.ID);
            builder.GainSpecificSpell(Guid.Parse("21583bea-73bc-4865-8b28-b112d84a8ad4"), Spells.Instances.Wildfire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4a7eb00-0d4a-428a-a66f-beab9403b790"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 198
            };
        }
    }
}
