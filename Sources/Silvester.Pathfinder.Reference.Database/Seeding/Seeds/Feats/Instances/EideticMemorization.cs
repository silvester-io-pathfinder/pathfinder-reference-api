using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EideticMemorization : Template
    {
        public static readonly Guid ID = Guid.Parse("d3481fc7-fb47-44e3-b536-65f75806333d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidetic Memorization",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9bf3e640-c272-47dc-93ab-ce9c8ffb97af"), Type = TextBlockType.Text, Text = "Pathfinders are often asked to study the intricacies of ancient history under less than ideal conditions, and you&#39;ve trained your brain to make the most of your limited time. You quickly memorize an inscription, scroll, or other piece of writing you can clearly see whose length is equivalent to no more than one page. You can then accurately recreate this writing using a (item: writing kit | Writing Set), (item: wax tablet | Wax Key Blank), or other writing medium, once you have reached safety." };
            yield return new TextBlock { Id = Guid.Parse("aa35b912-89aa-4ab5-8de0-c4ba3936c8c0"), Type = TextBlockType.Text, Text = "You don&#39;t need to understand the writing or identify the language to reproduce it. Your memory lasts until the next time you make your daily preparations; if you have not written down or otherwise recreated what you saw by this point, your memory fades and any attempt to recreate what you saw is garbled and unintelligible. You can have only one piece of writing memorized at a time; any previous memorization fades the next time you use this ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("58006fa3-c836-4f31-9f54-e804b2c557f2"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e958d80c-b084-4006-826e-489d72345d5f"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
