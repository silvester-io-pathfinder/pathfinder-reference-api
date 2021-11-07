using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflexiveGrip : Template
    {
        public static readonly Guid ID = Guid.Parse("9fc3e35e-41bf-4552-a0b6-bc1d65079abf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflexive Grip",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31ffc307-1fa0-4922-9c82-c75f9e4fb597"), Type = TextBlockType.Text, Text = "You keep hold of your weapons even when knocked out. You gain a +2 circumstance bonus to your Reflex DC when defending against checks to (action: Disarm) you. In addition, when you fall unconscious, you don&#39;t drop any weapons that you&#39;re currently wielding, though somebody else can remove them from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a0352623-7c37-4eef-bb42-11b3bbbc197c"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3a54f97-20c6-4192-9266-99e2dec57b85"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
