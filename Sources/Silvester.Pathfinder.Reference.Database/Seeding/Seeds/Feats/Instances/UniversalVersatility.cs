using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UniversalVersatility : Template
    {
        public static readonly Guid ID = Guid.Parse("b786d29d-04fa-4b7a-80c4-a69aec05f8d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Universal Versatility",
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
            yield return new TextBlock { Id = Guid.Parse("4606478e-c8ed-4616-8290-ca619bbb4c2a"), Type = TextBlockType.Text, Text = "You can access the fundamental abilities of any school of magic. During your daily preparations, choose one of the eight school spells gained by 1st-level specialist wizards. You can use that school spell until your next daily preparations. When you (Activity: Refocus), you can choose a different school spell from among those eight school spells, replacing the previous one. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClass(Guid.Parse("2ece8f73-c433-465e-8b19-ac286a973912"), Classes.Instances.Wizard.ID);
            builder.HaveNoMagicSchool(Guid.Parse("57a0aba9-91fa-4651-aa14-a03342f34814"));
            builder.HaveSpecificFeat(Guid.Parse("3f6c2cab-40d4-4695-98b1-2761003a5b02"), Feats.Instances.HandOftheApprentice.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab692f9d-1be7-4000-9534-f4346e4c0519"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
