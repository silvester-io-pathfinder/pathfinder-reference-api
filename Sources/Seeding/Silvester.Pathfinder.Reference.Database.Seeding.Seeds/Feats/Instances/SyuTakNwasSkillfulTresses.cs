using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SyuTakNwasSkillfulTresses : Template
    {
        public static readonly Guid ID = Guid.Parse("be3cebfa-d17a-4d20-b328-25e25ee91fd4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Syu Tak-Nwa's Skillful Tresses",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fbd327e4-0e38-4edd-a413-a5f8618abb98"), Type = TextBlockType.Text, Text = $"You can expertly control your living hair and use it to perform various tasks. You can perform simple {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions with your hair such as opening an unlocked door or picking up objects. Your hair can't perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish. Your hair can hold items of up to 1 Bulk, but can't Activate or attack with any items it's holding." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fa1a38e2-e606-41d2-af65-80bca7d019cf"), Feats.Instances.LivingHair.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63c92605-9905-4744-9edf-806081995646"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
