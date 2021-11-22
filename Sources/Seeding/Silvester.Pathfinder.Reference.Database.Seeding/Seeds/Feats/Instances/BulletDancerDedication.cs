using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletDancerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("274b4ec7-50b7-416a-aaa4-7d2c46bd4bbf");

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
            yield return new TextBlock { Id = Guid.Parse("542bb175-cfb4-4eef-9d65-76d2f24ddb7b"), Type = TextBlockType.Text, Text = "You've learned how to synchronize traditional martial arts and guns. You gain the (feat: Bullet Dancer Stance) action. Whenever your proficiency in any weapon increases to expert or beyond, you gain that new proficiency with bayonets, reinforced stocks, simple firearms and unarmed attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("c1136cba-ea09-4300-a4c9-30279a1b9389"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("d0658b0f-3032-4b02-93ee-0b8cb44e41ba"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Simple.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("897062e4-c612-47f4-a199-4aeee3bde9f6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
