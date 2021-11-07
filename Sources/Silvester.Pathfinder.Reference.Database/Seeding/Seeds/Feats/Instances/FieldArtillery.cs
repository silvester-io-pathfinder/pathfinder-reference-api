using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FieldArtillery : Template
    {
        public static readonly Guid ID = Guid.Parse("c02afa00-6238-4912-9a5a-fa93a50f8d9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Field Artillery",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e7f8d9b-4d7a-4bf0-873f-9905aaafa75d"), Type = TextBlockType.Text, Text = "While castles are generally obliging enough to stay in one place, out in the field positioning is of paramount importance—a gun in the wrong place is worse than useless. You can (action: Interact) with an adjacent mounted siege weapon to increase its Speed by 10 feet for one round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("902653ff-c228-413b-a2f9-39b4f9159df6"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("babbb1d8-7895-41fd-a438-42923beeb662"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
