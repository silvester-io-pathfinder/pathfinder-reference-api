using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WanderingHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("1ed96ce8-d175-4696-b191-8f3778a92d2a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wandering Heart",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bbc59016-7166-4cd3-9b7f-139429cdd594"), Type = TextBlockType.Text, Text = "While all elves adapt to their environments over time, you have traveled so widely and become attuned to so many environs that your body now changes more rapidly than other elves. After spending a week in an environment associated with an elf heritage (such as snow for arctic elf, or a forest or jungle for woodland elf) your heritage automatically changes to become that heritage. This never causes you to change to an elf heritage that isn’t related to an environment, such as ancient elf, seer elf, or whisper elf." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("1aa93358-9506-42f7-875d-4ef329c8e759"), or => 
            {
                or.HaveSpecificHeritage(Guid.Parse("d63e6679-c26e-4f34-8101-c0f19acc5d68"), Heritages.Instances.ArcticElf.ID);
                or.HaveSpecificHeritage(Guid.Parse("d2dc8b4a-d314-4d36-b63a-8b689de75386"), Heritages.Instances.CavernElf.ID);
                or.HaveSpecificHeritage(Guid.Parse("b1ea75a8-4848-4547-a3f2-5a7053abd90b"), Heritages.Instances.DesertElf.ID);
                or.HaveSpecificHeritage(Guid.Parse("670e1770-92d1-4887-ad72-f7802f112943"), Heritages.Instances.WoodlandElf.ID);
                or.Manual(Guid.Parse("a2eafcb5-85bb-42fe-a1c6-727c9f4db760"), "Any other elf heritage based on adapting to an environment.");
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
                Id = Guid.Parse("3d07f2e4-19e1-4db1-85da-a2789b815ede"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
