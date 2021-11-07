using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("e64eb133-c14d-4d46-9261-f5144345fd1a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Arrow",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times. Each time you do, select three additional types of ammunition as described above.",
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("024b6db1-9427-4621-a76b-aeb6313fd1dd"), Type = TextBlockType.Text, Text = "You imbue your ammunition with eldritch power. When you select this feat, choose three types of common magical ammunition of 4th level or lower from the Core Rulebook or the Advanced Player&#39;s Guide. Your GM might allow you to choose from other types of magical ammunition, such as uncommon ammunition, or ammunition from other books." };
            yield return new TextBlock { Id = Guid.Parse("19088f92-0ed0-48ef-ad7c-cffbda58bc76"), Type = TextBlockType.Text, Text = "When using Magic Arrow, you transform a non-magical arrow or bolt into a piece of ammunition of one type you chose. You must shoot the ammunition before the end of your turn or the magic dissipates. If the ammunition has an Activate entry, you still need to spend the required actions to activate the ammunition before shooting it. When you use Magic Arrow, you can choose a type of magical ammunition that is typically not available to the type of ammunition you’re using – for example, you can use (item: climbing bolt) on an arrow, even though that magical ammunition is normally only found on bolts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8442ea99-7a9e-40bf-a214-85e4c7d7c250"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27249934-3fe1-484e-9516-2a7f25d1b584"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
