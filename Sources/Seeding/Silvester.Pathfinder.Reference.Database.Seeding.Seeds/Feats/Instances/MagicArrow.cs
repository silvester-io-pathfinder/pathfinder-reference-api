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
    public class MagicArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("ee3d5575-bcb2-4d20-b263-8c315f2df839");

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
            yield return new TextBlock { Id = Guid.Parse("f7aab91d-8491-4719-94e2-fd6d1d93fa6d"), Type = TextBlockType.Text, Text = $"You imbue your ammunition with eldritch power. When you select this feat, choose three types of common magical ammunition of 4th level or lower from the Core Rulebook or the Advanced Player's Guide. Your GM might allow you to choose from other types of magical ammunition, such as uncommon ammunition, or ammunition from other books." };
            yield return new TextBlock { Id = Guid.Parse("4c1f9d75-1892-4d24-8da3-f9b8c07697a3"), Type = TextBlockType.Text, Text = $"When using Magic Arrow, you transform a non-magical arrow or bolt into a piece of ammunition of one type you chose. You must shoot the ammunition before the end of your turn or the magic dissipates. If the ammunition has an Activate entry, you still need to spend the required actions to activate the ammunition before shooting it. When you use Magic Arrow, you can choose a type of magical ammunition that is typically not available to the type of ammunition you're using – for example, you can use {ToMarkdownLink<Models.Items.Instances.MagicAmmunition>("climbing bolt", Items.MagicAmmunitions.Instances.ClimbingBolt.ID)} on an arrow, even though that magical ammunition is normally only found on bolts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("84b538eb-a590-4238-b6a8-4b2db0dc33c7"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("903f6aac-1572-4841-94c1-be2625230563"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
