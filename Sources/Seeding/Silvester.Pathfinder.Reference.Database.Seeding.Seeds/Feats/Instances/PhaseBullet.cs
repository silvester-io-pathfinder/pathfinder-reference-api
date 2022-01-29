using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhaseBullet : Template
    {
        public static readonly Guid ID = Guid.Parse("0005ca53-925f-4084-b891-a1e4a53e51ef");

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
            yield return new TextBlock { Id = Guid.Parse("4e9bc425-91fd-4d02-b4c2-e148b9e9e1d9"), Type = TextBlockType.Text, Text = $"You can aim your bullets not just in three normal dimensions, but in additional dimensions as well, allowing you to fire a magical shot that phases through everything but your target. Make a crossbow or firearm {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a foe who's observed or hidden to you (but not undetected). The ammunition travels to your target in a straight line, passing through any non-magical barriers or walls in its way, though magical barriers and force effects stop the bullet. The shot ignores all cover, the concealed condition, the hidden condition, and circumstance bonuses to AC from shields. It has a +4 status bonus to hit creatures wearing any type of armor. The {ToMarkdownLink<Models.Entities.Action>("Strike's", Actions.Instances.Strike.ID)} damage can't be reduced with a {ToMarkdownLink<Models.Entities.Feat>("Shield Block", Feats.Instances.ShieldBlock.ID)} reaction using a non-magical shield." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6a0ded2e-9d20-4a51-b717-f44da9467950"), Feats.Instances.SpellshotDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71a86b65-3ce3-424c-b682-c896156417a6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
