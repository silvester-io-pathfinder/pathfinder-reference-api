using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Entourage : Template
    {
        public static readonly Guid ID = Guid.Parse("cbe09fcc-1d35-4b2a-b429-568739ff1eb7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Entourage",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("661b579e-741d-4c13-bedd-d78c22615a49"), Type = TextBlockType.Text, Text = "~ Access: member of the Firebrands (third or four Rank)" };
            yield return new TextBlock { Id = Guid.Parse("b75eaf8e-15a7-4624-b704-02a98e08462d"), Type = TextBlockType.Text, Text = "You have a small group of admirers who tend to follow you around while you’re in civilized settlements. Your admirers are helpful to you, allowing you to make simple (action: Requests | Request) of them such as purchasing basic equipment with your funds or finding a room at an inn. These admirers do not travel with you to places that are obviously dangerous, including most adventure locations, but they’ll wait for you at the nearest settlement. Your admirers never use actions in encounter mode other than to retreat, and they abandon you if you intentionally bring them harm or at the GM’s discretion. When you (action: Gather Information), you can use your admirers to assist you, granting a +1 circumstance bonus to your Diplomacy check and reducing the time it takes even further (typically to 30 minutes, rather than 1 hour with the (feat: Hobnobber) feat alone). If you have the (feat: Sow Rumor) feat, you can have your admirers assist you, with the same benefits as (action: Gather Information)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("257fed4c-b314-4178-b11f-eaee03a78247"), Proficiencies.Instances.Master.ID, Skills.Instances.Diplomacy.ID);
            builder.HaveSpecificFeat(Guid.Parse("02063ff5-c56e-4532-863b-788e80c8d273"), Feats.Instances.Hobnobber.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37ad8db8-1927-4556-9c2c-83e2c995929a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
