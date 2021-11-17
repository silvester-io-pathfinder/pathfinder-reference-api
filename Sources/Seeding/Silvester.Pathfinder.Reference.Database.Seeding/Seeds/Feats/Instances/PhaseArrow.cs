using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhaseArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("0c1fdf24-3b5f-41a1-b0c5-35e8f66eafa9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phase Arrow",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b12eaad-3bc8-4cac-bc15-f68875039fe2"), Type = TextBlockType.Text, Text = "You can concentrate an immense amount of magic to create a piece of ammunition that phases through everything but your target. Make a bow (action: Strike) against a foe who is observed or hidden to you (but not undetected). The ammunition travels to your target in a straight line, passing through any non-magical barriers or walls in its way, though magical barriers stop the arrow. The shot ignores all cover, the concealed condition, the hidden condition, and circumstance bonuses to AC from shields. It has a +4 status bonus to hit creatures wearing any type of armor. The (action: Strike)’s damage can’t be reduced with a (feat: Shield Block) reaction using a non-magical shield." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("97ffde3f-6ce3-44d3-82ba-8ba67704a3bd"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81ddeddd-c804-4b60-9f00-b201cf7b46d5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
