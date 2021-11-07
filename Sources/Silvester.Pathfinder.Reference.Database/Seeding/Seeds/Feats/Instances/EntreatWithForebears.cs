using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EntreatWithForebears : Template
    {
        public static readonly Guid ID = Guid.Parse("d4959ab6-0607-4f91-8347-89e16fd0f3bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Entreat with Forebears",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c515334-ec42-4f5a-8082-253d13178e8a"), Type = TextBlockType.Text, Text = "Something about your presence causes creatures of your bloodline to, consciously or not, recognize you as one of their own, and you become inured to their tricks. You gain a +1 circumstance bonus to Diplomacy, Deception, and Intimidation checks when interacting with creatures that have the trait corresponding to your bloodline, and you gain a +1 circumstance bonus to Perception and saving throws against such creatures. For example, an aberrant bloodline sorcerer would gain this benefit against creatures with the aberration trait. The GM is the final arbiter of which creatures match your bloodline." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("4028c34c-bfc1-4478-a9be-167527cc2f1d"), "A bloodline that corresponds with a creature trait.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea7ecafb-225f-4e85-984d-1dffca9474d7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
