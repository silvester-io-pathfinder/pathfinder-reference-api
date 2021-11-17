using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmoredExercise : Template
    {
        public static readonly Guid ID = Guid.Parse("89695ccb-cd63-43bb-a59e-1be73ca44eaa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armored Exercise",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7322093b-119c-4ba5-bf8c-7c288b5f3d3a"), Type = TextBlockType.Text, Text = "You&#39;ve spent time training in your armor alongside other agents from the Swords. Your proficiency rank for light, medium, and heavy armor increases to expert for whichever of those you already had the trained proficiency rank in." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("25c7e202-0f30-449a-ba6c-adcbd0596651"), Feats.Instances.SwordmasterDedication.ID);
            builder.AddOr(Guid.Parse("49441c53-624f-4cb1-ad3e-6b21102b200f"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("ee5e17fc-6511-4431-97e5-1e88da54f4c2"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.LightArmor.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("b72c6006-d063-4dc4-aeb5-2001dbf2563e"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.MediumArmor.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("b20734c2-de77-41d6-b1de-939fe4b9435b"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.HeavyArmor.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38501128-0436-4b3b-ae18-9e2006d064e3"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
