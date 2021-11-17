using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Juggle : Template
    {
        public static readonly Guid ID = Guid.Parse("89c67a00-5660-4040-8a9a-4762e6d060fc");

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
            yield return new TextBlock { Id = Guid.Parse("4315e44f-cb23-48ef-8b40-0d9926735461"), Type = TextBlockType.Text, Text = "You can Juggle items and still use your hands between tosses. You can use the Juggle action in several ways." };
            yield return new TextBlock { Id = Guid.Parse("48445fd2-9bfe-41e5-9d3f-66c398efd76b"), Type = TextBlockType.Text, Text = "You can start to Juggle with a single stored item, an item you were carrying, or an unattended item within your reach. The item must be of light or negligible Bulk. You Juggle the item until the end of your next turn, unless you use this feat again next turn to continue Juggling (see below). While you are Juggling, you can use this action again to add another item to the Juggle, which must meet all the same requirements. You can Juggle a number of items equal to one more than the number of hands you are using to Juggle." };
            yield return new TextBlock { Id = Guid.Parse("db920ea4-e314-4be8-a812-eec6e169a7ca"), Type = TextBlockType.Text, Text = "You can also use this action to continue Juggling as long as you aren’t fatigued. When you do, you continue to Juggle until the end of your next turn. If you do not continue Juggling by the end of your turn, you cease Juggling and you drop all the items. You become fatigued if you continue Juggling for more than 10 minutes (60 rounds) within the course of an hour." };
            yield return new TextBlock { Id = Guid.Parse("5b8b570c-7c74-449c-8dfb-a6024b89622a"), Type = TextBlockType.Text, Text = "As long as you’re Juggling fewer than your maximum number of items, you have a free hand. You can wield weapons you are Juggling (but not shields or other items) as long as they can be wielded in one hand. For example, while you Juggle a (item: dagger) in one hand and wield a shield in the other, you are wielding the (item: dagger) but still have a free hand to (activity: Cast a Spell) with a material component. Juggling two or more weapons with one hand doesn’t allow you to use feats that require two weapons each held in a different hand." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("93ceea34-9c10-471c-b44e-e806b19bedb3"), requiredStatValue: 16, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("1fe625a5-85b3-4530-9e7f-20490ca5d1ac"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d26f09f0-d358-4463-bc5c-2f82a2053874"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
