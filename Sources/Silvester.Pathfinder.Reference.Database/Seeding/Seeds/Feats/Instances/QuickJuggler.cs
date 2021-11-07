using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickJuggler : Template
    {
        public static readonly Guid ID = Guid.Parse("cc448dfb-c08e-4a67-ad4c-672ec6104cae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Juggler",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3a89940e-e395-4381-bf52-661e9be40ddd"), Type = TextBlockType.Text, Text = "When you start to (feat: Juggle) or add another item to those you are (feat: Juggling | Juggle), you add two items instead of one. Increase the maximum number of items you can (feat: Juggle) by one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("474e3224-1ab8-47ff-a75e-51ed6331ec8e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificFeat(Guid.Parse("d7283b48-f099-4a82-bf0b-513250929ba1"), Feats.Instances.JugglerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61b754fe-59cd-498f-98e1-a42f162d5877"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
