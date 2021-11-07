using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickMount : Template
    {
        public static readonly Guid ID = Guid.Parse("56ac6a56-72a9-4edf-a63f-fd32d1e96443");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Mount",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8ee832cd-bcbf-4944-80c9-9859330ef39d"), Type = TextBlockType.Text, Text = "You and your mount can spring into action at a moment’s notice. You (action: Mount | Mount / Dismount) the creature and (action: Command an Animal) to issue it an order of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b2614c2f-a2bc-45ea-a05b-2a03988109e6"), Feats.Instances.CavalierDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("3b28b45b-e468-44d1-a6d1-f167132b7bbd"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72173bdf-a42d-4b7b-94e9-88834756e2ef"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
