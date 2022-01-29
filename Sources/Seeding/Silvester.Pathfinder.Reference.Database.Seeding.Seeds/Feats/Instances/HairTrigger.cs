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
    public class HairTrigger : Template
    {
        public static readonly Guid ID = Guid.Parse("77ba064f-2a55-4bb9-b488-1922999f6700");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hair Trigger",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your initial deed allows you to Interact to draw a weapon more than once, this feat allows you to replace one of these Interact actions and use the other one to draw a weapon. You can't replace both Interact actions with Strikes, but you can draw a loaded firearm or crossbow with one of the actions and immediately shoot it with the other.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d109f99-1173-4800-bb89-2045c311d0be"), Type = TextBlockType.Text, Text = $"No one can react faster than you can pull your trigger. When using your initial deed, instead of {ToMarkdownLink<Models.Entities.Action>("Interacting", Actions.Instances.Interact.ID)} to draw a weapon, you can {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a firearm or crossbow you're already wielding. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, the target is also flat-footed until the end of your first turn of the encounter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("8520a920-3ff5-49f3-aaa3-73b42dab29b4"), "Initial deed that allows you to Interact to draw a weapon.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb302461-6d3f-4282-9cad-e9f9ffd05b78"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
