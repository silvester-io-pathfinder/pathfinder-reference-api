using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiverseWeaponExpert : Template
    {
        public static readonly Guid ID = Guid.Parse("a6e70314-ba99-49a2-a003-ce4126bd2f0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diverse Weapon Expert",
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
            yield return new TextBlock { Id = Guid.Parse("8a9809b1-59c2-469c-b52c-225f4509f004"), Type = TextBlockType.Text, Text = "Your proficiency ranks for simple weapons and martial weapons increase to expert, and your proficiency rank for advanced weapons increases to trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1a95d269-17bc-450e-8266-87428950e236"), Feats.Instances.FighterDedication.ID);
            builder.HaveAnyWeaponCategorySpecificProficiency(Guid.Parse("38b0a22a-87ac-4026-96f9-22dfff800e64"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b4a275c-0d3a-4171-8e8d-8bcef5c7a252"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
