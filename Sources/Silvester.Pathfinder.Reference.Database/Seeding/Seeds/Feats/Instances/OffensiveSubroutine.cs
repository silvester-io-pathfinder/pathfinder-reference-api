using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OffensiveSubroutine : Template
    {
        public static readonly Guid ID = Guid.Parse("2d3f14a5-8b77-4e6b-af5b-7d91b80d49cb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Offensive Subroutine",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e7dda14-ee4e-4e88-a980-b43018220002"), Type = TextBlockType.Text, Text = "Nanites augment your attacks. You can choose to activate (feat: Nanite Surge) when you attempt an attack roll, instead of when you attempt a skill check. If you do, you gain a +1 status bonus to the triggering attack roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7e540c12-a47a-4f2d-bc53-3ce2433b8874"), Feats.Instances.NaniteSurge.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16b4a058-1a1d-4b91-bb01-c906fb500fb7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
