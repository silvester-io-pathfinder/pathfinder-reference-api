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
    public class PowerSlide : Template
    {
        public static readonly Guid ID = Guid.Parse("2b315059-3787-467a-9ae0-58719eccf773");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Power Slide",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce735046-b04f-4e79-b412-70fdfee5a586"), Type = TextBlockType.Text, Text = $"You throw the vehicle into a barely controlled skid, turning sharply to evade pursuit or bring your weapons to bear. You Drive with a –2 penalty to your piloting check, gaining the effects of the Drive action for the same number of actions you spent to Power Slide. At the end of the movement, if you succeed, you can turn the vehicle up to 90 degrees. If you critically succeed at your piloting check, you can instead turn the vehicle up to 180 degrees." };
            yield return new TextBlock { Id = Guid.Parse("b405cd87-fe29-4dd4-8222-556cdb387a9c"), Type = TextBlockType.Text, Text = $"You may use ONE-ACTION to THREE-ACTIONS when performing this activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("16708a07-880b-4a5b-b38d-8ee556e34d15"), Feats.Instances.TrickDriverDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c2e0cf8-d6ee-40ae-a049-2b3e57c4868c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
