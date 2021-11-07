using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickStudy : Template
    {
        public static readonly Guid ID = Guid.Parse("afe0e666-0283-48fb-a52a-1f3311eee176");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Study",
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
            yield return new TextBlock { Id = Guid.Parse("f2bfd09e-3680-43ea-9494-9725d6c8ffe0"), Type = TextBlockType.Text, Text = "During your daily preparations, you can study a particular subject to gain the trained proficiency rank in one Lore skill of your choice. You must have interacted with that subject in some way on the previous day, whether by reading about it, talking to someone knowledgeable on the topic, or experiencing it yourself. Alternatively, you can reference your notes to instead choose a Lore skill you’ve prepared before with Quick Study. This proficiency lasts until you prepare again. Since this proficiency is temporary, you can’t use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("79a8328c-e97f-459e-84da-f85a06f495ac"), Feats.Instances.LoremasteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("516c9c4f-008a-421c-80d7-70b3a01c45f4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
