using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WardMedic : Template
    {
        public static readonly Guid ID = Guid.Parse("7be35cbc-ca5c-4ab2-9851-aa99026a6ad8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ward Medic",
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
            yield return new TextBlock { Id = Guid.Parse("2c483635-2455-4844-8a9e-b804a5ee5b9e"), Type = TextBlockType.Text, Text = "You’ve studied in large medical wards, treating several patients at once and tending to all their needs. When you use (Action: Treat Disease) or (Action: Treat Wounds), you can treat up to two targets. If you’re a master in Medicine, you can treat up to four targets, and if you’re legendary, you can treat up to eight targets." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7cbabf8c-742f-44d5-a8a9-2538da4d9579"), Proficiencies.Instances.Expert.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48bbbdb3-aebf-43d4-a536-b18915f01d55"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
