using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmigersMobility : Template
    {
        public static readonly Guid ID = Guid.Parse("22ac6231-cf8d-4c7c-8208-450ee6547228");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armiger's Mobility",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("29cd5164-f804-4bc9-9b16-d29fcc6fcc9c"), Type = TextBlockType.Text, Text = "You’ve learned how best to move in heavy armor. When wearing heavy armor, if you meet the Strength requirement, instead of reducing the movement penalty by 5 feet, you reduce the penalty by 10 feet (typically reducing the penalty to 0). If you are a dwarf with the (feat: Unburdened Iron) feat, increase your Speed by 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("6e51ff01-4c48-41c6-aee6-9834373cb81f"), Proficiencies.Instances.Export.ID, ArmorCategories.Instances.Heavy.ID);
            builder.HaveSpecificFeat(Guid.Parse("b510baa9-f3b9-4c38-bc5a-dd028093e624"), Feats.Instances.HellknightArmigerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d33b8de2-1f40-40e4-8563-681db163bbbe"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
