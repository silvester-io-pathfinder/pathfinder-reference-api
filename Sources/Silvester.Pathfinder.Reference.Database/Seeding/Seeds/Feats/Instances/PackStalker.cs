using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PackStalker : Template
    {
        public static readonly Guid ID = Guid.Parse("3d2e1015-5f4d-40ff-a4d3-c5642db87ad9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pack Stalker",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b835c395-37fd-4a44-a12a-82c4d6313028"), Type = TextBlockType.Text, Text = "Ambushes are an honored gnoll tradition. You gain the (feat: Terrain Stalker) feat and can extend its effects to a single ally so long as they remain within 10 ft. of you. If you have master proficiency in Stealth, you can extend the effect to two allies. If you have legendary proficiency in Stealth, you can extend it to four allies." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a7e4f188-36e1-4e8b-b15c-ed37720e9c57"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificFeat(Guid.Parse("91af0e16-bc01-4771-8dae-71aedbce319e"), Feats.Instances.PackHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("128d6bca-9831-403a-999a-1fc6da9883e5"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
