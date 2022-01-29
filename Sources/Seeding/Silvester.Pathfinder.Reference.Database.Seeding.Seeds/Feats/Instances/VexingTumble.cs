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
    public class VexingTumble : Template
    {
        public static readonly Guid ID = Guid.Parse("4ff2f660-51f6-4ff7-867f-17cad6395c1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vexing Tumble",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("821b548b-f577-495b-bb31-3399c11ff21f"), Type = TextBlockType.Text, Text = $"You tumble around your foes, expertly avoiding their reactions. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to half your Speed and roll an Acrobatics check. Compare the result to the Reflex DC of each foe whose reach you began in or enter during the movement, in sequence." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("b3965420-0e87-4099-a247-acf251785b45"),
                CriticalSuccess = "This movement doesn't trigger reactions from the foe, the foe is flat-footed to you until the end of your turn, and you gain panache.",
                Success = "This movement doesn't trigger reactions from the foe, and you gain panache.",
                
                CriticalFailure = "Your movement immediately stops when you enter the creature's reach; if you began in the creature's reach, you don't move.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("baa23fc8-719a-4180-ad79-5b0bbaabf79e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
