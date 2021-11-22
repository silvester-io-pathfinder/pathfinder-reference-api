using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmigersMobility : Template
    {
        public static readonly Guid ID = Guid.Parse("a0caba9f-ee3d-4461-899b-fbe8ba72b52f");

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
            yield return new TextBlock { Id = Guid.Parse("a0f5a2d9-95f5-4b89-b031-ca3f9250c924"), Type = TextBlockType.Text, Text = "You've learned how best to move in heavy armor. When wearing heavy armor, if you meet the Strength requirement, instead of reducing the movement penalty by 5 feet, you reduce the penalty by 10 feet (typically reducing the penalty to 0). If you are a dwarf with the (feat: Unburdened Iron) feat, increase your Speed by 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("efb63836-375d-4a36-a8ef-a4381bb1f675"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.HaveSpecificFeat(Guid.Parse("4e8d1989-1f32-47b5-996d-1a3ad2d10181"), Feats.Instances.HellknightArmigerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6b5aaba-7bcd-4dba-bc35-066889f63e90"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
