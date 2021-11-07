using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmoredExercise : Template
    {
        public static readonly Guid ID = Guid.Parse("13934592-e2c8-4651-9a5b-ee3710078611");

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
            yield return new TextBlock { Id = Guid.Parse("4d4c0e18-0e88-4565-ba9f-89c3e44003d7"), Type = TextBlockType.Text, Text = "You&#39;ve spent time training in your armor alongside other agents from the Swords. Your proficiency rank for light, medium, and heavy armor increases to expert for whichever of those you already had the trained proficiency rank in." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("58f8a2ac-2d55-4316-b6a8-ede6c420acc0"), Feats.Instances.SwordmasterDedication.ID);
            builder.AddOr(Guid.Parse("d23b5cf7-063c-41af-b3de-feeb84767266"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("47bf9e8f-f6eb-41cd-a64d-0e1295254a48"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Light.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("3e92ad6c-1482-429b-8e68-4e25bba59436"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Medium.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("a59b87ff-2306-416c-bf48-001dadd6a68d"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Heavy.ID);
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
                Id = Guid.Parse("41b46ce6-6311-4711-9cb2-9a143ed6ddb1"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
