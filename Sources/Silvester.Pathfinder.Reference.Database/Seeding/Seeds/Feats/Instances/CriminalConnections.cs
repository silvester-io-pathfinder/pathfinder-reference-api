using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CriminalConnections : Template
    {
        public static readonly Guid ID = Guid.Parse("8dd24040-2b9f-4482-94c9-12315f0679ab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Criminal Connections",
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
            yield return new TextBlock { Id = Guid.Parse("7e171e27-e1b4-41de-8604-480695b01d36"), Type = TextBlockType.Text, Text = "You have dealings with a variety of unsavory characters, which you can leverage to trade favors or meet powerful people. When you’re in an area where you have connections (typically a settlement where you’ve spent downtime building connections or possibly another area in the same nation), you can attempt a Society check to arrange a meeting with an important criminal, such as a thieves’ guild leader, or ask for a favor in exchange for a later favor of your contact’s choice. The GM decides the DC based on the difficulty of the favor and the figure’s prominence." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1c52fb82-838c-4d1b-aa7b-ba45cba2ade9"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
            builder.HaveSpecificFeat(Guid.Parse("a5a663bf-7d4a-4108-b7cb-c67587bdca62"), Feats.Instances.Streetwise.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e01a5d0b-ba6e-4bf6-a92d-62477a2a3ced"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
