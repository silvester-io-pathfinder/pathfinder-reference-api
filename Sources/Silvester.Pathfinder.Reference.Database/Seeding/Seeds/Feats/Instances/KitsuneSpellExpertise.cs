using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KitsuneSpellExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("cf4c7bab-285b-4af2-abb3-a543daf7e143");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c64b68f-ad69-4ee5-b02e-2ce4250a6433"), Type = TextBlockType.Text, Text = "Your tails show your magical mastery. During your daily preparations, choose (spell: confusion), (spell: death ward), or (spell: illusory scene). You can (action: Cast this Spell | Cast a Spell) as a 5th-level divine innate spell once that day. You become an expert in divine spell DCs and divine spell attack rolls." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cb94d81c-1d90-495b-9fcd-d787b64ac01e"), Feats.Instances.KitsuneSpellMysteries.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f102c8d-c7a9-425d-ab51-2b837ac4e734"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
