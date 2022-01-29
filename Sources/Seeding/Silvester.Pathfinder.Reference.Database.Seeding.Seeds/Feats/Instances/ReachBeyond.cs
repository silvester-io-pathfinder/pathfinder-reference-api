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
    public class ReachBeyond : Template
    {
        public static readonly Guid ID = Guid.Parse("222daf3e-ced9-48da-a504-a6246184a328");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reach Beyond",
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
            yield return new TextBlock { Id = Guid.Parse("3ce9679d-a75c-4d52-a03c-7e9a2ddc4cb3"), Type = TextBlockType.Text, Text = $"You've learned to move your spiritual energy past yourself to attack spirits where others can't. You can make melee {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against incorporeal creatures that are inside solid objects as long as the object is within your reach. An incorporeal creature inside of a solid object is hidden, requiring you to succeed at a DC 11 flat check when you target it. You can spend an action, which has the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait, to focus on a creature inside of a solid object. If you do, the next melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} you make this turn requires you to succeed at only a DC 6 flat check to affect the creature." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5b4a9c5-b397-4c10-9102-2ec72f451b81"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
