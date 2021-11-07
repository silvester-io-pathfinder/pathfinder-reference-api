using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MunitionsMachinist : Template
    {
        public static readonly Guid ID = Guid.Parse("1b052078-3d57-4fa3-aeea-7d36dfbfb4da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Munitions Machinist",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("666e528f-70be-4323-8b9f-4f6af00dc9e9"), Type = TextBlockType.Text, Text = "You’re particularly adept at crafting ammunition and bombs. Your advanced alchemy level for ammunition and bombs increases to your level – 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("62c7b1e4-6954-48d8-b8e7-88442ba06e11"), Feats.Instances.MunitionsCrafter.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("402bba41-d060-48bd-8eda-fda3c5fea56f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7ec6131-6d10-48ef-8df6-a624747a12a1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
