using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryThief : Template
    {
        public static readonly Guid ID = Guid.Parse("9ec206db-6190-42aa-a123-60da166f9d52");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Thief",
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
            yield return new TextBlock { Id = Guid.Parse("c157f702-9764-4b62-a4f2-4f68924d1a51"), Type = TextBlockType.Text, Text = "Your ability to (Action: Steal) defies belief. You can attempt to (Action: Steal) something that is actively wielded or that would be extremely noticeable or time consuming to remove (like worn shoes or armor). You must do so slowly and carefully, spending at least 1 minute (and significantly longer for items that are normally time consuming to remove, like armor). Throughout this duration you must have some means of staying hidden, such as the cover of darkness or a bustling crowd. You take a -5 penalty to your Thievery check. Even if you succeed, if the item is extremely prominent – like a suit of full plate armor – onlookers will quickly notice it’s gone after you steal it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("381a37b4-1de4-484d-b236-41727e18b066"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Thievery.ID);
            builder.HaveSpecificFeat(Guid.Parse("2ffc9f4e-c2f8-4453-8959-7f57ec0bb3d8"), Feats.Instances.Pickpocket.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0149878a-6b26-4cc9-ac42-2b97cc8eae04"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
