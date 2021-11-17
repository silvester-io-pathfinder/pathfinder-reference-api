using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Entourage : Template
    {
        public static readonly Guid ID = Guid.Parse("a8f9ea89-15e5-4f2c-b053-0cb77f8f0c0a");

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
            yield return new TextBlock { Id = Guid.Parse("ed94267d-87f3-4089-9ce7-c845e829837a"), Type = TextBlockType.Text, Text = "~ Access: member of the Firebrands (third or four Rank)" };
            yield return new TextBlock { Id = Guid.Parse("830cdc0a-fe7c-4747-b845-0615a729155a"), Type = TextBlockType.Text, Text = "You have a small group of admirers who tend to follow you around while you’re in civilized settlements. Your admirers are helpful to you, allowing you to make simple (action: Requests | Request) of them such as purchasing basic equipment with your funds or finding a room at an inn. These admirers do not travel with you to places that are obviously dangerous, including most adventure locations, but they’ll wait for you at the nearest settlement. Your admirers never use actions in encounter mode other than to retreat, and they abandon you if you intentionally bring them harm or at the GM’s discretion. When you (action: Gather Information), you can use your admirers to assist you, granting a +1 circumstance bonus to your Diplomacy check and reducing the time it takes even further (typically to 30 minutes, rather than 1 hour with the (feat: Hobnobber) feat alone). If you have the (feat: Sow Rumor) feat, you can have your admirers assist you, with the same benefits as (action: Gather Information)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7ea0124f-adb7-4c05-83ba-dbef457d9630"), Proficiencies.Instances.Master.ID, Skills.Instances.Diplomacy.ID);
            builder.HaveSpecificFeat(Guid.Parse("8d64b556-82f6-476f-ac22-4a6f771c77e9"), Feats.Instances.Hobnobber.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6438cc35-ec7d-48d9-a66b-3f8a8c214cda"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}