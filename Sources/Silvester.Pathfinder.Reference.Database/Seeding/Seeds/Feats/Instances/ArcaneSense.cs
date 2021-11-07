using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneSense : Template
    {
        public static readonly Guid ID = Guid.Parse("7483d5bb-7bca-4167-a930-2e38abff0459");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Sense",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("002ed059-c52d-4de3-bee2-a2cd921f4bcd"), Type = TextBlockType.Text, Text = "Your study of magic allows you to instinctively sense its presence. You can cast 1st-level (spell: detect magic) at will as an arcane innate spell. If you’re a master in Arcana, the spell is heightened to 3rd level; if you’re legendary, it is heightened to 4th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6183d117-00e8-4a32-ae36-8ffa96886754"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5854b004-a578-4464-992a-13ff99070da1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
