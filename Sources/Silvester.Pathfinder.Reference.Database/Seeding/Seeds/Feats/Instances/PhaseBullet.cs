using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhaseBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("899cb726-d35e-43ae-ab1d-f59c3e6600aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phase Bullet",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c670cbd0-78df-44b9-8407-9605db3be031"), Type = TextBlockType.Text, Text = "You can aim your bullets not just in three normal dimensions, but in additional dimensions as well, allowing you to fire a magical shot that phases through everything but your target. Make a crossbow or firearm (action: Strike) against a foe who’s observed or hidden to you (but not undetected). The ammunition travels to your target in a straight line, passing through any non-magical barriers or walls in its way, though magical barriers and force effects stop the bullet. The shot ignores all cover, the concealed condition, the hidden condition, and circumstance bonuses to AC from shields. It has a +4 status bonus to hit creatures wearing any type of armor. The (action: Strike’s|Strike) damage can’t be reduced with a (feat: Shield Block) reaction using a non-magical shield." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2ff9d05e-5fd1-44e7-99c9-7ac4f65b640f"), Feats.Instances.SpellshotDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52775c46-2cc9-473a-bde1-e33a54c40b36"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
