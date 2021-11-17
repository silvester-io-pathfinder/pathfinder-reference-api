using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickContacts : Template
    {
        public static readonly Guid ID = Guid.Parse("3111ab97-c6a3-4ee8-9905-8449473987eb");

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
            yield return new TextBlock { Id = Guid.Parse("81095912-a223-4833-84ca-ff916133775e"), Type = TextBlockType.Text, Text = "You know where to go, who to talk to, and how to make new connections, fast. Upon entering a new settlement, spending 1 day of downtime allows you to build enough connections to make use of the (feat: Connections) or (feat: Criminal Connections) feats. If you’re legendary in Society, you can form the required connections within 1 hour of entering a new settlement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a98dfc07-77eb-43e9-9398-79fcce0115fa"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.AddOr(Guid.Parse("ba8aa46c-4bfe-4bfc-baf2-f439bfefab64"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("46cffa08-cee5-4984-94f6-38dc02eae481"), Feats.Instances.Connections.ID);
                or.HaveSpecificFeat(Guid.Parse("a5de7251-0802-4fdb-8d98-038f17aaf7d6"), Feats.Instances.CriminalConnections.ID);
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
                Id = Guid.Parse("b3c08a24-6291-4b7f-9b34-023a88064393"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
