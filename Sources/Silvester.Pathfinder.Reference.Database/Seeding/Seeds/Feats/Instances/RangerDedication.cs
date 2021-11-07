using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RangerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("98b8190c-3dae-4031-bf7e-c9b97d190ac9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ranger Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the ranger archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bf012d3d-311f-4da3-a866-1a31577f69c9"), Type = TextBlockType.Text, Text = "You become trained in Survival; if you were already trained in Survival, you instead become trained in another skill of your choice. You become trained in ranger class DC." };
            yield return new TextBlock { Id = Guid.Parse("3ed7e13a-4553-45f4-8e37-79a72dd0e700"), Type = TextBlockType.Text, Text = "You can use the (feat: Hunt Prey) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("eb8b65d6-6bae-41cc-8220-21e01733dba0"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("862dd7fe-920f-4ac5-be9c-7029764dfdbb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
