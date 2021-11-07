using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnightInShiningArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("e5c7b170-ecaf-4a28-8bf4-bbf759dd7df7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knight in Shining Armor",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cd534dfe-e24f-4fb9-b298-62d203a2bd03"), Type = TextBlockType.Text, Text = "As a knight in shining armor, you train daily in the heaviest armor, expanding your expertise to heavy armor. You gain expert proficiency in heavy armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c98c2dc9-cec1-4e97-9c03-31ea457df843"), Feats.Instances.KnightVigilantDedication.ID);
            builder.AddOr(Guid.Parse("b19c88e9-1430-4d72-90e7-8b9cf8cd8716"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("769c656c-07fd-49e0-8222-a7b308700d76"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Light.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("bf4826f9-d696-47ff-9419-2d4aa20540f6"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Medium.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("89e83915-e2fa-4fc7-98ef-fad890481990"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
            });
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("6ee2c615-44b0-40f0-8228-2352e8081521"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Heavy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a991b25c-9d92-4217-b918-508e01e8fd34"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
