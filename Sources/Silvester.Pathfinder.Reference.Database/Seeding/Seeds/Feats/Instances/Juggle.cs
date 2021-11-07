using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Juggle : Template
    {
        public static readonly Guid ID = Guid.Parse("527395be-50c1-4018-b497-d3b133613aa8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Juggle",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51e01ff9-bf27-4e8a-ad66-d7398807b183"), Type = TextBlockType.Text, Text = "You can Juggle items and still use your hands between tosses. You can use the Juggle action in several ways." };
            yield return new TextBlock { Id = Guid.Parse("a77cd88e-3df0-4711-ae72-455a51b6ffec"), Type = TextBlockType.Text, Text = "You can start to Juggle with a single stored item, an item you were carrying, or an unattended item within your reach. The item must be of light or negligible Bulk. You Juggle the item until the end of your next turn, unless you use this feat again next turn to continue Juggling (see below). While you are Juggling, you can use this action again to add another item to the Juggle, which must meet all the same requirements. You can Juggle a number of items equal to one more than the number of hands you are using to Juggle." };
            yield return new TextBlock { Id = Guid.Parse("42f5a8c3-ee36-4141-b37a-6a225ebcd407"), Type = TextBlockType.Text, Text = "You can also use this action to continue Juggling as long as you aren’t fatigued. When you do, you continue to Juggle until the end of your next turn. If you do not continue Juggling by the end of your turn, you cease Juggling and you drop all the items. You become fatigued if you continue Juggling for more than 10 minutes (60 rounds) within the course of an hour." };
            yield return new TextBlock { Id = Guid.Parse("90c83623-ebd1-45fe-bfe2-6be749ad593c"), Type = TextBlockType.Text, Text = "As long as you’re Juggling fewer than your maximum number of items, you have a free hand. You can wield weapons you are Juggling (but not shields or other items) as long as they can be wielded in one hand. For example, while you Juggle a (item: dagger) in one hand and wield a shield in the other, you are wielding the (item: dagger) but still have a free hand to (activity: Cast a Spell) with a material component. Juggling two or more weapons with one hand doesn’t allow you to use feats that require two weapons each held in a different hand." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("2695d4ae-cdef-47d9-ab3f-ef8c0c9d2c9a"), requiredStatValue: 16, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("229b2924-40b4-4f50-baef-5cf8b315f910"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a7e4b37-5684-4119-82f9-bcd53603a723"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
