using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryProfessional : Template
    {
        public static readonly Guid ID = Guid.Parse("cca58f20-7e81-4b69-9340-5fd2d1dffd48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Professional",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2d8290e9-c24a-4940-8905-f2e174158f4e"), Type = TextBlockType.Text, Text = "Your fame has spread throughout the lands (for instance, if you have Warfare Lore, you might be a legendary general or tactician). This works as (feat: Legendary Performer), except you gain higher-level jobs when you (action: Earn Income) with Lore." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyLoreProficiency(Guid.Parse("063ab9c4-d40e-4b5f-a266-fd9901a0d08d"), Proficiencies.Instances.Legendary.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a66f640-0d73-4353-91c9-10857a42d750"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
