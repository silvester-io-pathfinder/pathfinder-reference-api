using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletDancerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("8bb43cac-f8b0-41fe-bb06-0b3e254206f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullet Dancer Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9cba82ac-da41-4a62-89a7-f7bde84bce66"), Type = TextBlockType.Text, Text = "You’ve learned how to synchronize traditional martial arts and guns. You gain the (feat: Bullet Dancer Stance) action. Whenever your proficiency in any weapon increases to expert or beyond, you gain that new proficiency with bayonets, reinforced stocks, simple firearms and unarmed attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("cb80fc3c-5020-406d-95f6-53487326a18b"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmed.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("97f12da7-f977-49a1-95ec-03a94dde5379"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("919688eb-eba4-47c7-80e4-01c6f3730f4b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
