using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickContacts : Template
    {
        public static readonly Guid ID = Guid.Parse("4cd7c10a-0798-4882-b36c-0f2628070df9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Contacts",
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
            yield return new TextBlock { Id = Guid.Parse("2af6048e-33d1-4345-a1cd-394dd9f3580c"), Type = TextBlockType.Text, Text = "You know where to go, who to talk to, and how to make new connections, fast. Upon entering a new settlement, spending 1 day of downtime allows you to build enough connections to make use of the (feat: Connections) or (feat: Criminal Connections) feats. If you’re legendary in Society, you can form the required connections within 1 hour of entering a new settlement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("008c11f2-991a-475b-87cb-7e4be2571fd5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.AddOr(Guid.Parse("4b9e1c10-1705-4896-8356-87814194f9f4"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("15eb1c46-5568-4415-ad30-57b97777bf68"), Feats.Instances.Connections.ID);
                or.HaveSpecificFeat(Guid.Parse("e8df5d3c-a920-44af-9710-ca1cd4f382d4"), Feats.Instances.CriminalConnections.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aeead6ca-f802-4cab-a9be-0c9b8604465a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
