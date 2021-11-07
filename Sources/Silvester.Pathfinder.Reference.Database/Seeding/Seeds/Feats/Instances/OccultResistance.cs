using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OccultResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("2128f8ab-e089-4c09-bba4-0007036b0f76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Occult Resistance",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b2eda640-ed47-4ee2-9cab-261897ae4b26"), Type = TextBlockType.Text, Text = "Your study of occult practices has shown you how to best defend against them. You gain a +1 circumstance bonus to all saving throws against (trait: occult) effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0d97396c-19bd-4236-bc46-5fc224d50773"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ad7000e-41df-4441-a9f9-1844b3856233"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
